using UnityEngine;
namespace Sample
{
    public class InitializedTest : MonoBehaviour
    {
        [SerializeField] private int number=10;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            number = 20;
        }

        private void Update()
        {
            Debug.Log($"number:{number}");
        }

    }
}