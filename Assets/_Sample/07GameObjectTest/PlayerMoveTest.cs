using UnityEngine;
using UnityEngine.UIElements;
namespace Sample
{
    public class PlayerMoveTest : MonoBehaviour
    {

        #region Field

        public float moveSpeed = 5f;

        public Transform target;

        public GameObject targetGo;

        //private TargetTest targetTest;
        public TargetTest targetTest;

        //private MyTest myTest;
        public MyTest myTest;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //targetTest = target.GetComponent<TargetTest>();

            //targetTest.SetA(60);
            //Debug.Log($"targetTest.a:{targetTest.GetA()}");
            //targetTest.b = 30;
            //Debug.Log($"targetTest.b:{targetTest.b}");

            //myTest = this.transform.GetComponent<MyTest>();
            myTest = this.GetComponent<MyTest>();
            myTest.SetA(60);
            Debug.Log($"targetTest.a:{myTest.GetA()}");
           myTest.b = 30;
            Debug.Log($"targetTest.b:{myTest.b}");
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 dir = target.position - this.target.position;
            this.transform.Translate(Vector3.forward * Time.deltaTime *moveSpeed);
        }
    }
}