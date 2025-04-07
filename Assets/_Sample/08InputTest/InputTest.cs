using TMPro;
using UnityEngine;
namespace Sample
{
    public class InputTest : MonoBehaviour
    {
        public TextMeshProUGUI xText;
        public TextMeshProUGUI yText;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log($"Screen.width:{Screen.width}");
            Debug.Log($"Screen.height{Screen.height}");
        }

        // Update is called once per frame
        void Update()
        {
            //if (Input.GetKey("w"))
            //{
            //    Debug.Log("w키를 누르고 있다.");
            //}
            //if (Input.GetKeyDown(KeyCode.W))
            //{
            //    Debug.Log("w키를 눌렀다.");
            //}

            //if (Input.GetKeyUp("w"))
            //{
            //    Debug.Log("w키를 눌렀다 땠다.");
            //}


            //if (Input.GetButton("Jump"))
            //{
            //    Debug.Log("점프버튼 누르고 있다.");
            //}
            //if (Input.GetButtonDown("Jump"))
            //{
            //    Debug.Log("점프버튼 눌렀다 .");
            //}
            //if (Input.GetButtonUp("Jump"))
            //{
            //    Debug.Log("점프버튼 눌렀다 땠다.");
            //}

            //float hValue= Input.GetAxisRaw("Horizontal");
            //Debug.Log($"Horizontal:{hValue}");
            //float hValue = Input.GetAxisRaw("Vertical");
            //Debug.Log($"Horizontal:{hValue}");

            float mouseX = Input.mousePosition.x;
            float mouseY = Input.mousePosition.y;

            //xText.text ="MoseX:" + ((int)mouseX).ToString();
            //yText.text ="MoseY:" + ((int)mouseY).ToString();
            xText.text = ((int)mouseX).ToString() + "," + ((int)mouseY).ToString();
            xText.rectTransform.position = new Vector2(mouseX, mouseY);
        }
    }
}