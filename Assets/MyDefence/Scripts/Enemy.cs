using System;
using UnityEngine;
using UnityEngine.UI;
namespace MyDefence
{
    public class Enemy : MonoBehaviour
    {

        #region Field

        private float health;
        public Image healthBarImage;
        [SerializeField] private float startHealth = 100f;

        public float movespeed = 5f;

        private float startMoveSpeed;

        
        //waypoint 오브젝트 츠랜스폰 객체
        private Transform target;
        private int wayPointIndex = 0;

        [SerializeField]private int rewardGold = 50;

        public GameObject deathEffectPrefab;

        #endregion

       

        void Start()
        {
            wayPointIndex = 0;
            target= Waypoints.wayPoints[wayPointIndex];
            health = startHealth;
            startMoveSpeed = movespeed;
        }

     
        void Update()
        {
            Vector3 dir = target.position - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * movespeed, Space.World);


            float distance = Vector3.Distance(target.position, this.transform.position);
            //도착 판정
            if (distance <= 0.1f)
            { 
                GetNextTarget();

            }

            movespeed = startMoveSpeed;


        }

        void GetNextTarget()
        {

            if (wayPointIndex== Waypoints.wayPoints.Length-1)
            {


                PlayerStats.Uselife(1);            
                Destroy(this.gameObject);
                return;
            }
            wayPointIndex++;
           
            target = Waypoints.wayPoints[wayPointIndex];
            
        }

        public void TakeDamage(float damage)
        {
            health -= damage;
            Debug.Log($"Now Health:{health}");

            healthBarImage.fillAmount = health / startHealth;

            if (health <= 0f)
            {
                Die();
            }
        }

        private void Die()
        {
            PlayerStats.AddMoney(rewardGold);

            GameObject effectGo=Instantiate(deathEffectPrefab, this.transform.position, Quaternion.identity);
            Destroy(effectGo, 2f);
            Destroy(this.gameObject, 0f);
        }

        public void Slow(float rate)
        {
            movespeed = startMoveSpeed * (1-rate);
        }
    }
}