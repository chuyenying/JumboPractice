using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{
    [SerializeField] private List<Creature> creature;

    public delegate void Model_Delegate(string creatureName, Vector3 position);
    public event Model_Delegate PlayerDelegate;

    private void Start()
    {
        CreateCreature(creature[0], new Vector3(-600,0,0));
        CreateCreature(creature[1], new Vector3(0, 0, 0));
        CreateCreature(creature[2], new Vector3(600, 0, 0));
        creature[0].hp = 10;
        creature[1].hp = 8;
        creature[2].hp = 12;
    }


    public void CreateCreature(Creature creature_Data, Vector3 position)
    {
        PlayerDelegate(creature_Data.name, position);   //觸發event -->委派contorller LetViewCreatePrefab()
    }

    public void KnowWhichCreature(GameObject _creature, int mode)
    {
        for(int i=0; i< creature.Count; i++)
        {
            if (_creature.Equals(creature[i]))
            {
                if(mode == 0)
                {
                }
            }
        }
    }

    //public string Talk(int creature)
    //{
    //    if (creature == 0)
    //    {
    //        return $"我是{Player.name} 我有{Player.hp}點HP";
    //    }
    //    else if(creature == 1)
    //    {
    //        return $"我是{People.name} 我有{People.hp}點HP";
    //    }
    //    {
    //        return $"我是{Monster.name} 我有{Monster.hp}點HP";
    //    }

    //}
    //public string Hurt(int creature)
    //{
    //    if (creature == 0)
    //    {
    //        Player.hp = Player.hp - Player.attack;
    //        return ($"我是{Player.name} 我受{Player.attack}傷害! 剩下{Player.hp}點");
    //    }
    //    else if(creature==1)
    //    {
    //        People.hp = People.hp - People.attack;
    //        return ($"我是{People.name} 我受{People.attack}傷害! 剩下{People.hp}點");
    //    }
    //    else
    //    {
    //        Monster.hp = Monster.hp - Monster.attack;
    //        return ($"我是{Monster.name} 我受{Monster.attack}傷害! 剩下{Monster.hp}點");
    //    }
    //}
    //public string Attack(int creature)
    //{
    //    if (creature == 0)
    //    {
    //        Monster.hp = Monster.hp - Player.attack;
    //        return ($"{Player.name}對{Monster.name}發起攻擊! 造成了{Player.attack}點傷害!{Monster.name}現在剩下{Monster.hp}點HP");
    //    }
    //    else
    //    {
    //        Player.hp = Player.hp - Monster.attack;
    //        return ($"{Monster.name}對{Player.name}發起攻擊! 造成了{Monster.attack}點傷害!{Player.name}現在剩下{Player.hp}點HP");
    //    }
    //}
    //public string Conversaction(int creature)
    //{
    //    if (creature == 0)
    //    {
    //        return ($"那邊的{People.name} 目前血量剩下{People.hp}點HP");
    //    }
    //    else
    //    {
    //        return ($"那邊的{Player.name} 目前血量剩下{Player.hp}點HP");
    //    }
    //}

}
