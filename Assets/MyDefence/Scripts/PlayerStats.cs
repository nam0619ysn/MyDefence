using UnityEngine;
namespace MyDefence
{
    public class PlayerStats : MonoBehaviour
    {
        #region Field
        private static int money;
        [SerializeField] private int startMoney = 400;
        #endregion

        #region Property
        public static int Money
        {
            get{ return money; }
        }
        #endregion

        private void Start()
        {
            money = startMoney;
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
    }
}