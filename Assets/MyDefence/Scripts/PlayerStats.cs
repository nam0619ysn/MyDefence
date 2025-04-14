using UnityEngine;
namespace MyDefence
{
    public class PlayerStats : MonoBehaviour
    {
        #region Field
        private static int money;

        [SerializeField] private int startMoney = 400;

        private static int lives;
        [SerializeField] private int startLives = 10;
        #endregion


        #region Property
        public static int Money
        {
            get{ return money; }
        }
        public static int Lives
        {
            get{ return lives; }
        }
        #endregion

        private void Start()
        {
            money = startMoney;
            lives = startLives;
          
        }
        public static void AddMoney(int amount)
        {
            money += amount;
        }
        public static bool UseMoney(int amount)
        {
            if (money < amount)
            {
                Debug.Log("소지금을 부족합니다");
                return false;

            }
            money -= amount;
            return true;
        }

        public static bool HasMoney(int amount)
        {
            return money >= amount;
            
           
        }
        public static void Addlife(int amount)
        {
            lives += amount;
            
           
        }
        public static void Uselife(int amount)
        {
            lives -= amount;
            
           if(lives <= 0)
            {
                lives = 0;
                Debug.Log("GameOver");
            }
        }
    }
}