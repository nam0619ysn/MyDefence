using UnityEngine;
namespace Solid
{
    public class Vehicle : MonoBehaviour
    {
        #region Field
        public float speed;
        public Vector3 direction;
        #endregion
       public virtual void GoForward()
       {

       }
        public virtual void GoBack()
        {

        }
        public virtual void TurnLeft()
        {

        }
        public virtual void TurnRight()
        {

        }
        public class Car:Vehicle
        {
            public override void GoForward()
            {

            }

            public override  void GoBack()
            {

            }
            public override  void TurnLeft()
            {

            }
            public override void TurnRight()
            {

            }
        }

        public class Train : Vehicle
        {
            public override void GoForward()
            {

            }

            public override void GoBack()
            {

            }
            public override void TurnLeft()
            {

            }
            public override void TurnRight()
            {

            } 
           


        }
    }
}