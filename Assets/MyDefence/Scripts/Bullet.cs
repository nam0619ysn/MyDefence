using UnityEngine;

namespace MyDefence
{
    public class Bullet : MonoBehaviour
    {
        #region Field

       private Transform target;

        public float moveSpeed = 70f;
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

            transform.Translate(dir.normalized * Time.deltaTime * moveSpeed);

            void HitTarget()
            {
                Debug.Log("HitTarget");
                Destroy(target.gameObject);

                Destroy(this.gameObject);


            }
        }
    }
}