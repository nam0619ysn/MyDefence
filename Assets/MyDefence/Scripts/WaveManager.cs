using UnityEngine;
using System.Collections;
using TMPro;
namespace MyDefence
{
    public class WaveManager : MonoBehaviour
    {
        #region Field
        public GameObject enemyPrefab;

        public Transform startPoint;

        public float waveTimer = 5f;
        private float countdown = 0f;

        private int waveCount = 0;

        //UI CountdownText
        public TextMeshProUGUI countdownText;
        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            SpawnEnemy();
            SpawnWave();
        }
        void Update()
        {
            countdown += Time.deltaTime;
           if(countdown >= waveTimer)
            {
                //타이머
                StartCoroutine( SpawnWave());
               //타이머초기화
                countdown = 0f;
            }
            //UI
            countdownText.text = Mathf.Round(countdown).ToString();

        }

        IEnumerator SpawnWave()
        {
                waveCount++;

            PlayerStats.Rounds++;

                for(int i = 0; i < waveCount; i++)
                {
                    SpawnEnemy();

                yield return new WaitForSeconds(0.5f);
                }
                
        }

        void SpawnEnemy()
        {
            Instantiate(enemyPrefab,startPoint.transform.position   ,Quaternion.identity);
        }
    }
}