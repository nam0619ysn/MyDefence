using UnityEngine;
namespace MyDefence
{
    public class GameManager : MonoBehaviour
    {
        #region Field
        [SerializeField]private bool isCheat = false;
        #endregion

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                ShowMeTheMoney();
            }
        }

        void ShowMeTheMoney()
        {
            if(isCheat == false)
            {
                return;
            }

            PlayerStats.AddMoney(10000);
        }
        void LevelUpCheating()
        {
            
        }
    }
}