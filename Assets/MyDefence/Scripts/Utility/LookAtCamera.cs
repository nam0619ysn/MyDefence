using UnityEngine;
namespace MyDefence
{
    public class LookAtCamera : MonoBehaviour
    {

        #region Field
        private Camera m_MainCamera;

        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            m_MainCamera = Camera.main;
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 target = new Vector3(m_MainCamera.transform.position.x, m_MainCamera.transform.position.y, m_MainCamera.transform.position.z);
        }
    }
}