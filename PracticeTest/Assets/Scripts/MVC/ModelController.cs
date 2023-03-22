using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{
    public enum CreatureEnum
    {
        Player = 0,
        People = 1,
        Monster = 2
    };

    private const int Player = (int)CreatureEnum.Player;
    private const int People = (int)CreatureEnum.People;
    private const int Monster = (int)CreatureEnum.Monster;

    [SerializeField] private List<Creature> creature;

    public Action<Creature> CreatePrefab_Action;

    public void Init()
    {
        creature[Player].hp = 10;
        creature[People].hp = 8;
        creature[Monster].hp = 12;

        for (int i = 0; i < creature.Count; i++)
        {
            CreatePrefab_Action?.Invoke(creature[i]);  //觸發-->委派contorller LetViewCreatePrefab()
        }
    }

    public string Talk(int CreatureType)
    {
        return $"我是{creature[CreatureType].name} 我有{creature[CreatureType].hp}點HP";
    }


    public string Hurt(Creature creatureClass)
    {
        creatureClass.hp = creatureClass.hp - creatureClass.attack;
        return ($"我是{creatureClass.name} 我受{creatureClass.attack}傷害! 剩下{creatureClass.hp}點");
    }

    public string Attack(int CreatureType, bool IsOnNicePerson)
    {
        if (CreatureType == Player)
        {
            if (IsOnNicePerson)
            {
                creature[Monster].hp = creature[Monster].hp - creature[Player].attack;
                return ($"{creature[Player].name}對{creature[Monster].name}發起攻擊! 造成了{creature[Player].attack}點傷害!{creature[Monster].name}現在剩下{creature[Monster].hp}點HP");
            }
            else
            {
                creature[People].hp = creature[People].hp - creature[Player].attack;
                return ($"{creature[Player].name}對{creature[People].name}發起攻擊! 造成了{creature[Player].attack}點傷害!{creature[People].name}現在剩下{creature[People].hp}點HP");
            }
        }
        else
        {
            creature[Player].hp = creature[Player].hp - creature[Monster].attack;
            return ($"{creature[Monster].name}對{creature[Player].name}發起攻擊! 造成了{creature[Monster].attack}點傷害!{creature[Player].name}現在剩下{creature[Player].hp}點HP");
        }
    }
    public string Conversaction(Creature creatureClass)
    {
        if (creatureClass.creature == 0)
        {
            return ($"那邊的{creature[1].name} 目前血量剩下{creature[1].hp}點HP");
        }
        else
        {
            return ($"那邊的{creature[0].name} 目前血量剩下{creature[0].hp}點HP");
        }
    }
}