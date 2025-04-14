using UnityEngine;
using static UnityEngine.GraphicsBuffer;
namespace MyDefence
{
    public class Rocket : Bullet
    {
        #region Field

        public float damageRange = 3.5f;
        private Transform target;

        public string enmeyTag = "Enemy";

        #endregion
        public void SetTarget(Transform _target)
        {
            this.target = _target;
        }
        protected override void HitTarget()
        {
            GameObject effectGo = Instantiate(bulletImpactEffectPrefab, this.transform.position, Quaternion.identity);
            Destroy(effectGo, 2f);


            Explosion();

            Destroy(this.gameObject);

        }
       

        private void Explosion()
        {
            Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, damageRange);
            foreach(var hitCollider in hitColliders)
            {
                if (hitCollider.tag == enmeyTag)
                {

                    float distance = Vector3.Distance(this.transform.position, hitCollider.transform.position);

                    float damage = attackDamage * ((damageRange -distance) / damageRange);

                    Enemy enemy = hitCollider.GetComponent<Enemy>();
                    if(enemy != null)
                    {
                        enemy.TakeDamage(damage);
                    }
                }

            }
        }


        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(this.transform.position, damageRange);
        }
    }
}