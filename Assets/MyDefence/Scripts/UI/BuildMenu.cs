using UnityEngine;
namespace MyDefence
{
    public class Buildmenu : MonoBehaviour
    {

        #region Field
        public TowerBluePrint machineGuntower;
        public TowerBluePrint rocketTower;
        public TowerBluePrint laserTower;
        #endregion
        public void MachineGunButton()
        {
           
            BuildManager.Instance.SetTowerToBuild(machineGuntower);
        }


     
       public void RocketTowerButton()
       {
           
            BuildManager.Instance.SetTowerToBuild(rocketTower);
       } 
       public void LaserTowerButton()
       {
           
            BuildManager.Instance.SetTowerToBuild(laserTower);
       }

        

    }
}