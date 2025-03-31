using Unity.Mathematics;
using UnityEngine;

namespace Sample
{
    public class RotateTest : MonoBehaviour
    {
        float x = 0;

        public float turnsSpeed = 5f;

        public float moveSpeed = 5f;

        public Transform target;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //this.transform.rotation = Quaternion.Euler(90f,0f,0f);
            //this.transform.rotation = Quaternion.Euler(0f,90f,0f);
            //this.transform.rotation = Quaternion.Euler(0f,0f,90f);

            

        }

        // Update is called once per frame
        void Update()
        {
            //x += 1;

            //this.transform.rotation= Quaternion.Euler(x, 0f, 0f);
            //this.transform.rotation = Quaternion.Euler(0f, x, 0f);
            //this.transform.rotation= Quaternion.Euler(0f, 0f, x);


            //x += Time.deltaTime*10;
            //this.transform.rotation = Quaternion.Euler(0f, x, 0f);
            //자전
            // this.transform.Rotate(Vector3.up*Time.deltaTime*turnsSpeed);

            //타겟 중심으로 회전-공전
            //transform.RotateAround(target.transform.position, Vector3.up, 20 * Time.deltaTime);

            //타겟 방향 회전
            //Vector3 dir = target.position - this.transform.position;
            //Quaternion targetlookRotation = Quaternion.LookRotation(dir);
            //transform.rotation = lookRotation;
            //Quaternion lookRotation= Quaternion.Lerp(this.transform.rotation,targetlookRotation,Time.deltaTime*turnsSpeed);
            //Vector3 eulerRotation = lookRotation.eulerAngles;
            //this.transform.rotation = Quaternion.Euler(0f, eulerRotation.y, 0f);


            Vector3 dir = target.position - this.transform.position;
            this.transform.rotation = Quaternion.LookRotation(dir);
            this.transform.Translate(dir.normalized * Time.deltaTime * moveSpeed, Space.World);
            //this.transform.Translate(dir.normalized * Time.deltaTime * moveSpeed, Space.Self);
        }
    }
}