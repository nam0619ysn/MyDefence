using UnityEngine;
namespace Sample
{
    public class ObjectTest : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(this.transform.ToString());

            Debug.Log(this.gameObject.ToString());


            //this.transform.gameObject == this.gameObject;
            //this.gameObject.transform == this.transform;
        }

    }
}