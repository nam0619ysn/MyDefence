using UnityEngine;
using TMPro;
namespace MyDefence
{
    public class DrawMoneyUI : MonoBehaviour
    {
        public TextMeshProUGUI moneyTex;
        // Update is called once per frame
        void Update()
        {
            moneyTex.text = PlayerStats.Money.ToString();
        }
    }
}