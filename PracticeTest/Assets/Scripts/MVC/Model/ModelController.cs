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



    [SerializeField] private List<Creature> creature;

    public Action<Creature> CreatePrefab_Action;

    public void Init()
    {
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

    public string Attack(int MainAttacker, int WhoisAttacked)
    {
        creature[WhoisAttacked].hp = creature[WhoisAttacked].hp - creature[MainAttacker].attack;
        return ($"{creature[MainAttacker].name} 對 {creature[WhoisAttacked].name} 發起攻擊! 造成了 {creature[MainAttacker].attack} 點傷害! {creature[WhoisAttacked].name} 現在剩下 {creature[WhoisAttacked].hp} 點HP");
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