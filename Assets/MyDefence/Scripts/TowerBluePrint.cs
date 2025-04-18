using UnityEngine;
using System;
namespace MyDefence
{
    [Serializable]
    public class TowerBluePrint
    {
        public GameObject towerPrefab;
        public int cost;

        public GameObject upgradePrefab;
        public int upgradecost;


        public int Sellcost
        {
            get{ return cost / 2; }
        }

        //public int GetSellCost()
        //{
        //    return cost / 2;
        //}
    }
}