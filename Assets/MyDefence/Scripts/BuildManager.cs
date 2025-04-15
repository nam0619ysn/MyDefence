using Unity.VisualScripting;
using UnityEngine;
namespace MyDefence
{
    public class BuildManager : MonoBehaviour
    {
        #region Singletone
        private static BuildManager instance;

        public static BuildManager Instance
        {
            get { return instance; }


        }
        private void Awake()
        {
            if (instance != null)
            {
                Destroy(gameObject);
                return;
            }
            instance = this;
        }
        #endregion

        #region Field
        private TowerBluePrint towerToBuild;


        public TileUI tileUI;
        private Tile selectTile;

        private int buildCost;
        //public GameObject machineGunPrefab;
        //public GameObject rocketTowerPrefab;
        private int cost;
        #endregion

        #region Property
        public bool NotEnoughMoney
        {
            get { return PlayerStats.Money < towerToBuild.cost; }
        }

        public bool CannotBuuild
        {
            get { return towerToBuild == null; }
        }
        #endregion
        private void Start()
        {
          
        }
        public TowerBluePrint GetTowerToBuild()
        {
            return towerToBuild;
        }


        public void SetTowerToBuild(TowerBluePrint tower)
        {
            towerToBuild = tower;
            
        }
        public  void SelectTile(Tile tile)
        {

            if(selectTile == tile)
            {
                DeselectTile();
                return;
            }
            selectTile = tile;
            tileUI.ShowTileUI(selectTile);
        }

        public void DeselectTile()
        {
            tileUI.HideTileUI();
            selectTile = null;
        }

        public int GetBulidCost()
        {
            return cost;
        }
       
    }
}