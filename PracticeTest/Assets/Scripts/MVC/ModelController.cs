using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{
    [SerializeField] private List<Creature> creature;

    public Action<Creature> CreatePrefab_Action;

    public void Init()
    {
        creature[0].hp = 10;
        creature[1].hp = 8;
        creature[2].hp = 12;

        for (int i = 0; i < creature.Count; i++)
        {
            CreateCreature(creature[i]);
        }

    }

    public void CreateCreature(Creature creatureClass)
    {
        CreatePrefab_Action?.Invoke(creatureClass);   //觸發-->委派contorller LetViewCreatePrefab()
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

    public string Attack(Creature creatureClass)
    {
        if (creatureClass.creature == 0)
        {
            creature[2].hp = creature[2].hp - creatureClass.attack;
            return ($"{creatureClass.name}對{creature[2].name}發起攻擊! 造成了{creatureClass.attack}點傷害!{creature[2].name}現在剩下{creature[2].hp}點HP");
        }
        else
        {
            creature[0].hp = creature[0].hp - creatureClass.attack;
            return ($"{creatureClass.name}對{creature[0].name}發起攻擊! 造成了{creatureClass.attack}點傷害!{creature[0].name}現在剩下{creature[0].hp}點HP");
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
