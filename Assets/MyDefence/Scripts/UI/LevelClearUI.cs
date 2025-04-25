using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
namespace MyDefence
{
    public class LevelClearUI : MonoBehaviour
    {
        #region Field
        //æ¿∆‰¿Ã¥ı
        public SceneFader fader;

        [SerializeField] private string loadToScene = "MainMenu";
        [SerializeField] private string loadToNext = " LevelSelect";

      
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created


        public void Continue()
        {
            fader.FadeTo(loadToNext);
        }
        public void Menu()
        {
            fader.FadeTo(loadToScene);
        }
    }
}