using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{
    [SerializeField] private Creature Player;
    [SerializeField] private Creature People;
    [SerializeField] private Creature Monster;

    private void Awake()
    {
        Player.hp = 10;
        People.hp = 8;
        Monster.hp = 12;
    }

    public string Talk(int creature)
    {
        if (creature.Equals(0))
        {
            return $"我是{Player.name} 我有{Player.hp}點HP";
        }
        else if (creature.Equals(1))
        {
            return $"我是{People.name} 我有{People.hp}點HP";
        }
        else
        {
            return $"我是{Monster.name} 我有{Monster.hp}點HP";
        }
    }
    public string Hurt(string creature)
    {
        if (creature == "玩家")
        {
            Player.hp = Player.hp - Player.attack;
            return ($"我是{Player.name} 我受{Player.attack}傷害! 剩下{Player.hp}點");
        }
        else if (creature == "村民")
        {
            People.hp = People.hp - People.attack;
            return ($"我是{People.name} 我受{People.attack}傷害! 剩下{People.hp}點");
        }
        else
        {
            Monster.hp = Monster.hp - Monster.attack;
            return ($"我是{Monster.name} 我受{Monster.attack}傷害! 剩下{Monster.hp}點");
        }
    }
    public string Attack(string creature)
    {
        if (creature == "玩家")
        {
            Monster.hp = Monster.hp - Player.attack;
            return ($"{Player.name}對{Monster.name}發起攻擊! 造成了{Player.attack}點傷害!{Monster.name}現在剩下{Monster.hp}點HP");
        }
        else if (creature == "怪物")
        {
            Player.hp = Player.hp - Monster.attack;
            return ($"{Monster.name}對{Player.name}發起攻擊! 造成了{Monster.attack}點傷害!{Player.name}現在剩下{Player.hp}點HP");
        }
        else
        {
            return "出現錯誤!";
        }
    }
    public string Conversaction(string creature)
    {
        if (creature == "玩家")
        {
            return ($"那邊的{People.name} 目前血量剩下{People.hp}點HP");
        }
        else if (creature == "村民")
        {
            return ($"那邊的{Player.name} 目前血量剩下{Player.hp}點HP");
        }
        else
        {
            return "出現錯誤!";
        }
    }
}
