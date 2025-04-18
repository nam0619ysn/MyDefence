using UnityEngine;
namespace Solid
{
    public class RoadVehicle : MonoBehaviour,IMoveable,ITurnable
    {
        public void GoForward()
        {

        }
        public void GoBack()
        {

        }
        public void TurnLeft()
        {

        }
        public void TurnRight()
        {

        }
    }


    public class CarR : RoadVehicle
    {

    }
    public class Truck : RoadVehicle
    {

    }
}