using UnityEngine;
using static UnityEngine.GraphicsBuffer;
namespace MyDefence
{
    public class IntervalParticleSystemPlayer : MonoBehaviour
    {
        #region Field   
        public ParticleSystem particleSystemToPlay;

        public float interval;
        private float countdown = 0f;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            countdown = 0f;
        }
        private void Update()
        {
            countdown += Time.deltaTime;
            if(countdown >= interval)
            {
                PlayParticleEffect();
                countdown = 0f;
                
            }
        }

        void PlayParticleEffect()
        {

            if(particleSystemToPlay == null)
            {
                return;
            }
            particleSystemToPlay.Play();
        }
    }
}