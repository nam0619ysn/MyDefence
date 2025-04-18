using UnityEngine;
namespace Solid
{
    public class UnRefactoryedPlayer : MonoBehaviour
    {
        private Vector3 inputVector;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            HandleInput();
            Move(inputVector);
        }

        private void HandleInput()
        {
            //인풋
        }
        private void Move(Vector3 inputVector)
        {
            //이동기는
        }

        private void PlayRandomAudioClip()
        {
            //사운드
        }

        private void PlaySoundEffect()
        {
            //사운드
        }
    }
}