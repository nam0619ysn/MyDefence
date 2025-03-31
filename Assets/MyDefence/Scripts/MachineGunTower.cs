using System.Threading;
using UnityEngine;
namespace MyDefence
{
    public class MachineGunTower : MonoBehaviour
    {

        #region Field

        public float attackRange = 7f;
        private Transform target;

        public string ememyTag="Enemy";

        public float searchTimer = 0.5f;
        private float countdown = 0f;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            InvokeRepeating("UpdateTarget", 0f, 0.5f);
        }
        private void UpdateTarget()
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag(ememyTag);
            Debug.Log(ememyTag);
            float minDistance = float.MaxValue;
            GameObject nearEnemy = null;
            foreach (var enemy in enemies)
            {
                float distance = Vector3.Distance(this.transform.position, enemy.transform.position);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearEnemy = enemy;
                }
            }
            Debug.Log($"minDistance:{ minDistance}");
            if (minDistance != null && minDistance<= attackRange)
            {
                target=nearEnemy.transform;
                Debug.Log("Find Target");
            }
            else
            {
                target = null;
            }
                
        }

        private void Update()
        {

            //countdown += Time.deltaTime;
            //if (countdown>=searchTimer)
            //{
            //    UpdateTarget();
            //     countdown= 0f;
            //}
            
        }

        public void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(this.transform.position,attackRange);
        }
    }
}