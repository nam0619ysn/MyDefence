using UnityEngine;
namespace MyDefence
{
    public class MoveTest : MonoBehaviour
    {

        private float speed = 5f;
        Vector3 targetPosition = new Vector3(7f, 1f, 8f);

        void Start()
        {
            //this.transform.position=new Vector3(7f, 1f, 8f);
            //this.transform.position = targetPosition;
            //Debug.Log(this.transform.position);
        }

        // Update is called once per frame
        void Update()
        {
            //성능 좋은
            //10프레임 -1초에 10만큼
            //this.transform.position.z = this.transform.position.z + 1;
            //this.transform.position = this.transform.position + new Vector3(0f, 0f, 1f)*Time.deltaTime*20;
            //this.transform.position = this.transform.position + new Vector3(0f, 0f, -1f)*Time.deltaTime*20;
            //this.transform.position = this.transform.position + new Vector3(-1f, 0f, 0f)*Time.deltaTime*20;
            //this.transform.position = this.transform.position + new Vector3(1f, 0f, 0f)*Time.deltaTime*20;
            //this.transform.position = this.transform.position + new Vector3(0f, 1f, 0f)*Time.deltaTime*20;
            //this.transform.position = this.transform.position + new Vector3(0f, -1f, 0f)*Time.deltaTime*20;


            //성능 나쁜
            //2프레임-1초에 2만큼
            //this.transform.position+=new Vector3(0f, 0f, 1f)*Time.deltaTime*20;;
            //this.transform.position+= new Vector3(0f, 0f, 1f)*Time.deltaTime*20;

            //this.transform.position+= new Vector3.forward;
            //this.transform.position+= new Vector3.right;
            //방향*속도*Time.deltaTime


            //this.transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime;

            //this.transform.position += Vector3.forward * Time.deltaTime*speed;
            //this.transform.Translate(Vector3.forward * Time.deltaTime *speed);

            //이동 방행 (목표위치-현위치),(목표위치-현위치).normalized
            //dir.magnitude:ㅂ백터 크기 길이
            //dir.normalized:길이가 1인 백터.정규화된 백터 잔위 백터
            //Vector3 dir = targetPosition - this.transform.position;
            //transform.Translate(dir * Time.deltaTime * speed);

            // Space.World, Space.Self
            //transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
            transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
        }
    }
}