using UnityEditor.Build.Content;
using UnityEngine;
namespace Sample
{
    public class FactoryTest : MonoBehaviour
    {
        private void Start()
        {
            //MonsterFactory monsterFactory = new MonsterFactory();

            //Monster slime = monsterFactory.CreateMonster(MonsterType.M_Slime);
            //slime.Attack();

            //Monster zombie = monsterFactory.CreateMonster(MonsterType.M_Zombie);
            //zombie.Attack();

            //Monster slime2= monsterFactory.CreateMonster(MonsterType.M_Goblin);
            //slime2.Attack();

            SlimeFactory slimeFactory = new SlimeFactory();
            Monster slime = slimeFactory.CreateMonster();
            slimeFactory.SlimeCount();
            Debug.Log($"{slimeFactory.count}");
            slime.Attack();

           ZombieFactory zombieFactory = new ZombieFactory();
            Monster zombie = slimeFactory.CreateMonster();
            zombieFactory.AddSomething();
            zombie.Attack();
        }
    }
}