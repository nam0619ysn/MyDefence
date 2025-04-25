using UnityEngine;
namespace Sample
{
    //생성 메소드 추상화
    public interface IMonsterFactory
    {
        //모스터 변환라는 ㅐ토리
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
            Debug.Log("다른 무언가");
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