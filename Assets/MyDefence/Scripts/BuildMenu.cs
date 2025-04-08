using UnityEngine;
namespace MyDefence
{
    public class Buildmenu : MonoBehaviour
    {

        #region Field
        public TowerBluePrint machineGuntower;
        public TowerBluePrint rocketTower;
        #endregion
        public void MachineGunButton()
        {
            Debug.Log("towertoBuild에 .machineGunPrefab 저장");
            BuildManager.Instance.SetTowerToBuild(machineGuntower.towerPrefab);
        }


     
       public void RocketTowerButton()
       {
            Debug.Log("towertoBuild에 RocketTowerPrefab 저장");
            BuildManager.Instance.SetTowerToBuild(rocketTower.towerPrefab);
       }
    }
}