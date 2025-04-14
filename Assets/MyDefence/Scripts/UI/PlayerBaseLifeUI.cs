using UnityEngine;
using TMPro;
namespace MyDefence
{
    public class PlayerBaseLifeUI : MonoBehaviour
    {
        #region Field

        public TextMeshProUGUI livesText;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            livesText.text = PlayerStats.Lives.ToString();
        }
    }
}