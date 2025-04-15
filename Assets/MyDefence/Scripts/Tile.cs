using UnityEngine;

namespace MyDefence
{
    public class Tile : MonoBehaviour
    {
        #region Field
        //public Color hoverColor;

        // private Color startColor;
        //돈충분
        public Material hoverMaterial;

        /// 돈 부족
        public Material moneyMaterial;
      
        private Material startMaterial;

        private Renderer renderer;

        private BuildManager buildManager;

        private GameObject tower;

       public TowerBluePrint bluePrint;

        public GameObject buildEffectPrefab;


        #endregion

        #region Property
        public bool IsUpgrade { get; private set; }
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            buildManager = BuildManager.Instance;
            renderer = this.transform.GetComponent<Renderer>();
            //startColor = renderer.material.color;
            startMaterial = renderer.material;
        }
        private void OnMouseDown()
        {
            //Debug.Log("터렛 설치");
            //Instantiate(towerPrefab, this.transform.position, Quaternion.identity);
           

            if (tower != null)
            {
                buildManager.SelectTile(this);
                return;
            }

            if (buildManager.CannotBuuild)
            {
                Debug.Log("설치 타워가 없다,");
                return;
            }

            BuildTower();
        }

        void BuildTower()
        {

            if (buildManager.NotEnoughMoney)
                return;

            bluePrint = buildManager.GetTowerToBuild();

            
            //돈 계산
             PlayerStats.UseMoney(bluePrint.cost);
            
           

             tower = Instantiate(bluePrint.towerPrefab, this.transform.position, Quaternion.identity);

             GameObject effectGo= Instantiate(buildEffectPrefab, this.transform.position, Quaternion.identity);
             Destroy(effectGo,2f);
            

            //초기화
            buildManager.SetTowerToBuild(null);
            Debug.Log($"건설하고도 남은돈{PlayerStats.Money}");


        }

        public void UpgradeTower()
        {
            if (!PlayerStats.HasMoney(bluePrint.upgradecost))
            {
                Debug.Log("돈 부족");
                return;
            }
            PlayerStats.UseMoney(bluePrint.upgradecost);

            Destroy(tower);
            IsUpgrade = true;

            tower = Instantiate(bluePrint.upgradePrefab, this.transform.position, Quaternion.identity);
            GameObject effectGo = Instantiate(buildEffectPrefab, this.transform.position, Quaternion.identity);
            Destroy(effectGo, 2f);
            buildManager.SetTowerToBuild(null);
        }
        private void OnMouseEnter()
        {
            if (buildManager.GetTowerToBuild() == null)
            {

                return;
            }
            if (buildManager.NotEnoughMoney)
            {
                renderer.material = moneyMaterial;
            }
            else
            {
         
            renderer.material = hoverMaterial;
            }

           
        }
        //private void OnMouseDrag()
        //{
        //    Debug.Log("OnMouseDrag");
        //}

        private void OnMouseExit()
        {
            //Debug.Log("OnMousExist");
            //renderer.material.color = hoverColor;
            //renderer.material.color = Color.white;
            renderer.material = startMaterial;
        }
    }
}
