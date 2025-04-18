using UnityEngine;
namespace MyDefence
{
    public class GameManager : MonoBehaviour
    {
        #region Field
        [SerializeField]private bool isCheat = false;


       public GameObject gameOverUI;

        private static bool isGameOver=false;

        

        #endregion

        #region Property

        public static bool IsGameOver
        {
            get { return isGameOver; }
        }
        #endregion


        private void Start()
        {
            isGameOver = false;
        }

        private void Update()
        {

            if (IsGameOver)
                return;


            if (PlayerStats.Lives <= 0)
            {
                ShowGameOverUI();
            }

            if (Input.GetKeyDown(KeyCode.M))
            {
                ShowMeTheMoney();
            }

            if (Input.GetKeyDown(KeyCode.O)  && isCheat==true)
            {
                ShowGameOverUI();
            }
        }

        void ShowGameOverUI()
        {

           
            isGameOver = true;
            gameOverUI.SetActive(true);
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