using UnityEngine;
using UnityEngine.SceneManagement;
namespace MyDefence
{
    public class MainMenu : MonoBehaviour
    {
        #region Field
        [SerializeField]
        private string loadToScene = "PlayScene";
        public GameObject play;
        public GameObject quit;
        #endregion

      

        
        public void Play()
        {
            
            SceneManager.LoadScene("PlayScene");
           
            Debug.Log("Goto PlayScen");
        }

        public void Quit()
        {
            Debug.Log("GameQuit");
            Application.Quit();
        }
    }
}