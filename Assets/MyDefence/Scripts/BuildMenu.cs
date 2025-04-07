using UnityEngine;
namespace MyDefence
{
    public class Buildmenu : MonoBehaviour
    {
       public void MachineGunButton()
        {
            Debug.Log("towertoBuild에 .machineGunPrefab 저장");
            BuildManager.Instance.SetTowerToBuild(BuildManager.Instance.machineGunPrefab);
        }


     
       public void RocketTowerButton()
       {
            Debug.Log("towertoBuild에 RocketTowerPrefab 저장");
            BuildManager.Instance.SetTowerToBuild(BuildManager.Instance.rocketTowerPrefab);
       }
    }
}