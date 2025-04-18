using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using Unity.VisualScripting;
namespace MyDefence
{
    public class Title : MonoBehaviour
    {
        #region Field
        public GameObject anyKey;
        [SerializeField]
        private string loadToScene = "MainMenu";

        private bool isShow = false;

        [SerializeField]
        private float titleTimer = 2f;
        private float countdown = 0f;

        [SerializeField]
        private float spawnDelay = 2f;
        private float spawTime;

        private bool isOneTime = false;
        #endregion


        private void Start()
        {
            // countdown = 0f;
            //countdown = titleTimer;
            //spawTime = Time.time;
            isShow = false;
            //InvokeRepeating("SpawnMonster", 1f, 2f);

            //Invoke("SpawnMonster",spawnDelay);
            //StartCoroutine(Spawn());
            StartCoroutine(titleProcess());
        }
        // Update is called once per frame
        void Update()
        {
            //countdown += Time.deltaTime;
            //if(countdown >= titleTimer)
            //{
            //    GoToMenu();

            //    countdown = 0f;
            //}

            //countdown -= Time.deltaTime;
            //if(countdown <= 0f)
            //{
            //    GoToMenu();

            //    countdown = titleTimer;
            //}

            //if ((spawTime + spawnDelay) <= Time.time)
            //{
            //    SpawnMonster();

            //    spawTime = Time.time;
            //}


            //countdown -= Time.deltaTime;
            //if (isOneTime==false)
            //{
            //    countdown += Time.deltaTime;
            //    if (countdown >= titleTimer)
            //    {
            //        GoToMenu();

            //        countdown = 0f;
            //        isOneTime = true;
            //    }
            //}

            if (Input.anyKeyDown && isShow)
            {
                StopAllCoroutines();
                GoToMenu();
            }

        }
        IEnumerator titleProcess()
        {
            yield return new WaitForSeconds(titleTimer);
            ShowAnyKey();
            yield return new WaitForSeconds(titleTimer*10f);
            GoToMenu();
        }
        private void ShowAnyKey()
        {
            anyKey.SetActive(true);
            isShow = true;
        }
        private void GoToMenu()
        {
            
            SceneManager.LoadScene(loadToScene);
        }

        private void SpawnMonster()
        {
            Debug.Log("SpawnMonster");
        }
        IEnumerator Spawn()
        {
            yield return new WaitForSeconds(spawnDelay);
            SpawnMonster();
        }
    }
}