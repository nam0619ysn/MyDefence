using System.Data.SqlTypes;
using Unity.Mathematics;
using UnityEngine;

namespace Sample
{
    public struct  CBox
    {
        public float x;
        public float y;
        public float w;
        public float h;

    }

    struct CCircle 
    {
        public float x;
        public float y;
        public float r;
    }

    public class HiTest : MonoBehaviour
    {
        public Transform target;

        public float moveSpeed = 8f;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private bool CheckHitBox(CBox a, CBox b)
        {
            float dx = (a.x > b.x) ? (a.x - b.x) : (b.x - a.x);
            float dy = (a.y > b.y) ? (a.y - b.y) : (b.y - a.y);

            if(dx<=(a.w/2 + b.w/2) && dy <= (a.h / 2 + b.h / 2))
            {
                return true;
            }
            return false;
        }

        private bool CheckHitCircle(CCircle a, CCircle b)
        {
            float dx = a.x - b.x;
            float dy = a.y - b.y;

            float distanceS = dx * dx + dy * dy;

            
            if(distanceS <= (a.r + b.r)*(a.r+b.r))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckArrivePosition()
        {
            float distance = Vector3.Distance(target.position, this.transform.position);

            if (distance < 0.5f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckPassPosition()
        {
            float distance = Vector3.Distance(target.position, this.transform.position);

            // dir.normalized*Time.deltatime*moveSpeed;
            float distanceThisFrame = Time.deltaTime * moveSpeed;

            if(distance <=distanceThisFrame)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}