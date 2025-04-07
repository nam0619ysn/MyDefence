using UnityEngine;

namespace MyDefence
{
    public class Tile : MonoBehaviour
    {
        #region Field
        //public Color hoverColor;

        // private Color startColor;

        public Material hoverMaterial;
        private Material startMaterial;

        private Renderer renderer;

        private BuildManager buildManager;
        private GameObject tower;
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

            if (BuildManager.Instance.GetTowerToBuild() == null)
            {
                Debug.Log("설치 타워가 없다,");
                return;
            }

            if (tower != null)
            {
                Debug.Log("타워를 설치할수 없다.,");
                return;
            }
            tower = Instantiate(BuildManager.Instance.GetTowerToBuild(), this.transform.position, Quaternion.identity);

            buildManager.SetTowerToBuild(null);
        }
        private void OnMouseEnter()
        {
            if (buildManager.GetTowerToBuild() == null)
            {

                return;
            }


            //renderer.material.color=hoverColor;
            renderer.material = hoverMaterial;
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
