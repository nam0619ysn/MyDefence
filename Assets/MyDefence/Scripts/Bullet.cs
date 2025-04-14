using UnityEngine;

namespace MyDefence
{
    public class Bullet : MonoBehaviour
    {
        #region Field

       private Transform target;

        public float moveSpeed = 70f;
        public GameObject bulletImpactEffectPrefab;

       [SerializeField] protected float attackDamage = 50f;
        #endregion
      
        public void SetTarget(Transform _target)
        {
            this.target = _target;
        }
        // Update is called once per frame
        void Update()
        {
            if (target == null)
            {
                Destroy(this.gameObject);
                return;
            }

            Vector3 dir = target.position - this.transform.position;
            float distanceThisFrame = Time.deltaTime * moveSpeed;
            if (dir.magnitude <= distanceThisFrame)
            {
                HitTarget();
                return;
            }

            transform.Translate(dir.normalized * Time.deltaTime * moveSpeed,Space.World);

            transform.LookAt(target);
        }

            protected virtual  void HitTarget()
            {
                GameObject effectGo= Instantiate(bulletImpactEffectPrefab, this.transform.position,Quaternion.identity);
                Destroy(effectGo,2f);

              
                Damage(target);

                Destroy(this.gameObject);

            }
        protected  void Damage(Transform _target)
        {
            //원샸원킬
            // Destroy(target.gameObject);

            //attackdamage 만큼감산
           
            Enemy enemy = _target.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.TakeDamage(attackDamage);
            }
            
        }
        
    }
}