using UnityEngine;
namespace Sample
{
    public class MonsterFactory 
    {
        public Monster CreateMonster(MonsterType monsterType)
        {
            switch (monsterType)
            {
                case MonsterType.M_Slime:
                    return new Slime();
                break;

                case MonsterType.M_Zombie:
                    return new Zombie();
                    break;
                case MonsterType.M_Goblin:
                    return new Goblin();
                    break;
            }
            return null;
        }
    }
}