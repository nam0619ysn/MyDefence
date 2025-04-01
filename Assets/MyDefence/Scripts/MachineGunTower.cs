using System.Collections;
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

        public Transform partToRotate;
        public float turnSpeed = 5f;


        public float shootTimer = 1f;
        private float shootCountdown = 0f;

        public GameObject bulletPrefab;
        public Transform firePoint;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            InvokeRepeating("UpdateTarget", 0f, 0.5f);
        }
        private void UpdateTarget()
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag(ememyTag);
            //Debug.Log(ememyTag);
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
            //Debug.Log($"minDistance:{ minDistance}");
            if (minDistance != null && minDistance<= attackRange)
            {
                target=nearEnemy.transform;
               // Debug.Log("Find Target");
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
            if (target == null)
                return;
            LockOn();

            //타이머

            shootCountdown += Time.deltaTime;
            if (shootCountdown >= shootTimer)
            {
                Shoot();
                
                //타이머초기화
                shootCountdown = 0f;
                
            }
        }
        private void Shoot()
        {
          //  Debug.Log("Shoot");
           GameObject bulletGo= Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            Bullet bullet = bulletGo.GetComponent<Bullet>();
            bullet.SetTarget(target);
        }
        void LockOn()
        {
            Vector3 dir = target.position - this.transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(dir);
            Quaternion lookRotation = Quaternion.Lerp(partToRotate.rotation,targetRotation,Time.deltaTime*turnSpeed);
            Vector3 eulerRotation = lookRotation.eulerAngles;
            partToRotate.rotation = Quaternion.Euler(0f, eulerRotation.y, 0f);

        }

        public void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(this.transform.position,attackRange);
        }

        
    }
}