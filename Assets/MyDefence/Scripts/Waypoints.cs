using UnityEngine;

namespace MyDefence
{
    public class Waypoints : MonoBehaviour
    {
        //waypoint들의 정보를 가져오는 클래스
        #region Field
        public static Transform[] wayPoints;
        #endregion
        private void Awake()
        {
            wayPoints = new Transform[this.transform.childCount];
            for(int i = 0; i < wayPoints.Length; i++)
            {
               
                wayPoints[i] = this.transform.GetChild(i);

               // Debug.Log($"{wayPoints[i].position}");
            }
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}