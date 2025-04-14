using UnityEngine;
using System.Collections;
using System.Threading;
namespace MyDefence
{
    public class LazorTower : Tower
    {
        #region Field
        public LineRenderer lineRenderer;
        public ParticleSystem impactEffect;
        public Light impactLight;

        [SerializeField] private float laserDamage = 30f;

        [SerializeField] private float sloqwRate=0.4f;
        #endregion
      

        protected override void Update()
        {
            if (target == null)
            {

                if (lineRenderer.enabled)
                {
                    lineRenderer.enabled = false;
                    impactEffect.Stop();
                    impactLight.enabled = false;
                }
                return;
            }

            LockOn();
            Laser();

        }

        void Laser()
        {

            //dir * Time.deltaTime* moveSpeed;
            float damage = laserDamage * Time.deltaTime;
            //Enemy targetEnemy = target.GetComponent<Enemy>();
           

            if (targetEnemy != null)
            {

                targetEnemy.TakeDamage(damage);
                targetEnemy.Slow(sloqwRate);
            }

            if (lineRenderer.enabled == false)
            {
                lineRenderer.enabled = true;
                impactEffect.Play();
                impactLight.enabled = true;
            }
            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, target.position);

            //방향
            Vector3 dir = firePoint.position - target.position;
            impactEffect.transform.position = target.position + dir.normalized / 2f;
            impactEffect.transform.rotation = Quaternion.LookRotation(dir);
        }
    }
}