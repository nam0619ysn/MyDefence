using UnityEngine;
namespace MyDefence
{
    public class Rotate : MonoBehaviour
    {
        public Vector3 rotationSpeed;

        private void Update()
        {
            transform.localEulerAngles += rotationSpeed;
        }
    }
}