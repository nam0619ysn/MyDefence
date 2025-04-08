using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Sample
{
    public class MoneyTest : MonoBehaviour
    {
        #region Field
        private int gold;

        [SerializeField]
        private int startGold ;

        public TextMeshProUGUI goldText;

        public Button button1000;
        public Button button9000;
        #endregion

        private void Start()
        {
            gold = startGold;
            Debug.Log($"소지금{startGold}지급");

           
        }

        private void Update()
        {
            goldText.text = gold.ToString() + "Gold";

            if (HasGold(1000))
            {
                button1000.interactable = true;
            }
            else
            {
                button1000.interactable = false;
            }

            if (HasGold(9000))
            {
                button9000.image.color = Color.white;
            }
            else
            {
                button9000.image.color=Color.red;
            }
        }

        public void AddGold(int amount)
        {
            gold += amount;
        }

        public bool UseGold(int amount)
        {
            if(gold < amount)
            {
                Debug.Log("소지금 부족");
                return false;
            }
            gold -= amount;
            return true;
        }

        public bool HasGold(int amount)
        {
            if (gold >0)
            {
               
                return false;
            }
            gold -= amount;
            return true;
        }
        public void SaveButton()
        {
            Debug.Log("1000Gold");
            AddGold(1000);
        }
        public void Item1000()
        {
            if (UseGold(1000) == true)
            {
                Debug.Log("1000구매");
            }
        }
        public void Item9000()
        {
            
            if (UseGold(9000) == true)
            {
                Debug.Log("9000구매");
            }
        }
    }
}