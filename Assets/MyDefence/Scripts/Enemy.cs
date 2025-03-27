using System;
using UnityEngine;
namespace MyDefence
{
    public class Enemy : MonoBehaviour
    {

        #region Field
        private float speed = 10f;

        private Vector3 targetPosition;
        private int wayPointIndex = 0;
        #endregion

       

        void Start()
        {
            targetPosition = Waypoints.wayPoints[wayPointIndex].position;
        }

     
        void Update()
        {
            Vector3 dir = targetPosition - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * speed, Space.World);


            float distance = Vector3.Distance(targetPosition, this.targetPosition);
            //도착 판정
            if (distance <= 0.1f)
            {
                Debug.Log("도착");

                //다음 타겟 설정
                targetPosition = Waypoints.wayPoints[1].position;


               
            }
        }
    }
}