using UnityEngine;
namespace MyDefence
{  
    public class CameraControll : MonoBehaviour
    {
        #region Field

        public float moveSpeed = 10f;
        public float scrollSpeed = 10f;
        public float scrollMin = 10f;
        public float scrollMax = 40f;
        public bool isCannotMoce = false;

        #endregion



        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            isCannotMoce = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (GameManager.IsGameOver)
                return;

            //if (Input.GetKey(KeyCode.Escape))
            //{
            //    isCannotMoce = !isCannotMoce;
            //}
            //if (isCannotMoce)
            //    return;

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(Vector3.back * Time.deltaTime * moveSpeed, Space.World);
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);
            }

            float mouseX = Input.mousePosition.x;
            float mouseY = Input.mousePosition.y;
            if (mouseY <= 10 && mouseY > 0)
            {
                this.transform.Translate(Vector3.back * Time.deltaTime * moveSpeed, Space.World);
            }

            if (mouseY >= (Screen.height - 10) && mouseY < Screen.height)
            {
                this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
            }

            if (mouseX <= 10 && mouseX > 0)
            {
                this.transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);
            }

            if (mouseX >= (Screen.width - 10) && mouseX < Screen.width)
            {
                this.transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);
            }
            float scroll = Input.GetAxis("Mouse ScrollWheel");
           // Debug.Log($"ScrollWHeel: {scroll}");

            Vector3 upMove = this.transform.position;
            upMove.y += (scroll*1000) * Time.deltaTime * scrollSpeed;
            upMove.y = Mathf.Clamp(upMove.y,scrollMin,scrollMax);
            this.transform.position = upMove;

        }
    }
}