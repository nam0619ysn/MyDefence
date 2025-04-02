using UnityEngine;
namespace Sample
{
    public class Singletone 
    {
        private static Singletone instance;

        public static Singletone Instance
        {
            get
            {
                if (instance == null)
                {
                    instance= new Singletone();
                }
                    return instance;
            }
        }

        private static int number;
        //public Singletone Instance()
        //{
        //    if (instance == null)
        //    {
        //        instance = new Singletone();
        //    }
        //    return instance;
        //}

    }
}