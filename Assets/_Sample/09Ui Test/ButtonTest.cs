using UnityEngine;
namespace Sample
{
    public class ButtonTest : MonoBehaviour
    {
        #region Field

        public GameObject FireButton;
        public GameObject JumpButton;

        #endregion

        public void FireButon()
        {
            Debug.Log("Fire 버튼 눌렀습니다");
        } 
        public void Jump()
        {
            Debug.Log("Jump 버튼 눌렀습니다");
        }

         void Update()
        {
            
        }
    }
}