using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace MyDefence
{
    public class GameoverUI : MonoBehaviour
    {
        #region Field
        public TextMeshProUGUI roundText;
        #endregion

        private void OnEnable()
        {
            roundText.text = PlayerStats.Rounds.ToString();
        }
        public void Update()
        {
            roundText.text = PlayerStats.Rounds.ToString();
        }
        public void Retry()
        {

            //GameManager.IsGameOver = false;

           // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }

        public void Menu()
        {
            Debug.Log("GOTO MENU");
        }

     

    }
}