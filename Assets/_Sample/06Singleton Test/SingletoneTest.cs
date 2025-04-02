using UnityEngine;
namespace Sample
{
    public class SingletoneTest : MonoBehaviour
    {
        private static SingletoneTest instance;

        public static SingletoneTest Instance
        {
            get
            {
               
                return instance;
            }
        }

        private void Awake()
        {
            if(instance != null)
            {
                Destroy(gameObject);
                return;
            }
            instance = this;

            //DontDestroyOnLoad(gameObject);
        }

        public int number;
    }
}