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
        private GameObject towerToBuild;
        public GameObject machineGunPrefab;
        #endregion

        public GameObject GetTowerToBuild()
        {
            return towerToBuild;
        }

        public void Start()
        {
            towerToBuild = machineGunPrefab;
        }
    }
}