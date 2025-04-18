using UnityEngine;
using UnityEngine.UI;
namespace MyDefence
{
    public class ImageTest : MonoBehaviour
    {
        #region Field
        public Button Skillbtn;
        public Image skillButtonImage;


        [SerializeField]
        private float countdown = 0f;
        private float interval=3f;

        private bool isCharge = false;
        #endregion

        private void Start()
        {
            countdown = 0f;
        }
        private void Update()
        {
            if (isCharge)
            {
                return;
            }

            countdown += Time.deltaTime;
            if (countdown >= interval)
            {
              
                Skillbtn.interactable = true;

               
                isCharge = true;
            }
            skillButtonImage.fillAmount = countdown / interval;


        }
        public void SkillUSe()
        {
            Skillbtn.interactable = false;

            countdown = 0f;
            isCharge = false;

        }
    }
}