using UnityEngine;
namespace Sample
{
    public class PlayerTest : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //StaticTest.number = 10;
            //Debug.Log($"StaticTest.number:{StaticTest.number}");

            var singletoneA = Singletone.Instance;
            var singletoneB = Singletone.Instance;
            if (singletoneA == singletoneB)
            {
                Debug.Log(singletoneA.ToString());
            }

            SingletoneTest.Instance.number = 10;
            Debug.Log($"ingletoneTest.Instance.number:{SingletoneTest.Instance.number}");
        }


    }
}