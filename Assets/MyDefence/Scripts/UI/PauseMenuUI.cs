using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
namespace MyDefence
{

    public class PauseMenuUI : MonoBehaviour
    {
        #region Field

        public GameObject pauseUI;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Toggle();

            }
       
        }

        public void Retry()
        {
           
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public void Menu()
        {
            Debug.Log("GOTO MENU");
        }

        public void Continue()
        {
            Debug.Log("Conrinue");
            Toggle();
        }
        void Toggle()
        {
            pauseUI.SetActive(!pauseUI.activeSelf);

           
           
            if (pauseUI.activeSelf )
            {
                //활성화
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }

           
        }
    }
}