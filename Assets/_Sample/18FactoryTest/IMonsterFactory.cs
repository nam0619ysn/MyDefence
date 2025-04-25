using UnityEngine;
namespace Sample
{
    //���� �޼ҵ� �߻�ȭ
    public interface IMonsterFactory
    {
        //���� ��ȯ��� ���丮
        public Monster CreatMocster()
        {
            return new Slime();
        }
    }

    public class SlimeFactory : IMonsterFactory
    {
        public int count = 0;
        public Monster CreateMonster()
        {
            return new Slime();
        }
        public void SlimeCount() => count++;
    }

    public class ZombieFactory : IMonsterFactory
    {
        public Monster CreateMonster()
        {
            return new Zombie();
        }

        public void AddSomething()
        {
            Debug.Log("�ٸ� ����");
        }
    }

    public class SkeletonFactory : IMonsterFactory
    {
        public Monster CreateMonster()
        {
            return new Skeleton();
        }

        
    }
}