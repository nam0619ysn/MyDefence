using System;
using UnityEngine;
namespace MyDefence
{
    public class Enemy : MonoBehaviour
    {

        #region Field
        public float speed = 5f;

        //private Vector3 targetPosition;
        //waypoint 오브젝트 츠랜스폰 객체
        private Transform target;
        private int wayPointIndex = 0;
        #endregion

       

        void Start()
        {
            wayPointIndex = 0;
            target= Waypoints.wayPoints[wayPointIndex];
        }

     
        void Update()
        {
            Vector3 dir = target.position - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * speed, Space.World);


            float distance = Vector3.Distance(target.position, this.transform.position);
            //도착 판정
            if (distance <= 0.1f)
            { 
                GetNextTarget();

            }




        }

        void GetNextTarget()
        {

            if (wayPointIndex== Waypoints.wayPoints.Length-1)
            {
                Debug.Log("종점도착");
                Destroy(this.gameObject);
                return;
            }
            wayPointIndex++;
           // Debug.Log($"{wayPointIndex}도착"); 
            target = Waypoints.wayPoints[wayPointIndex];
            
        }
    }
}