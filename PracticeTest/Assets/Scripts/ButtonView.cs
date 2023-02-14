using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour // Reference to UI
{
    [SerializeField] private Creature Player;
    [SerializeField] private Creature People;
    [SerializeField] private Creature Monster;

    public void Talk(string ButtonName)
    {
        if (ButtonName == "玩家")
        {
            Debug.Log($"我是{Player.name} 我有{Player.hp}點HP");
        }
        else if (ButtonName == "村民")
        {
            Debug.Log($"我是{People.name} 我有{People.hp}點HP");
        }
        else if (ButtonName == "怪物")
        {
            Debug.Log($"我是{Monster.name} 我有{Monster.hp}點HP");
        }
    }

    public void Hurt(string ButtonName)
    {
        if (ButtonName == "玩家")
        {
            Player.hp = Player.hp - Player.hurt;
            Debug.Log($"我是{Player.name} 我受{Player.hurt}傷害! 剩下{Player.hp}點");
        }
        else if (ButtonName == "村民")
        {
            People.hp = People.hp - People.hurt;
            Debug.Log($"我是{People.name} 我受{People.hurt}傷害! 剩下{People.hp}點");
        }
        else if (ButtonName == "怪物")
        {
            Monster.hp = Monster.hp - Monster.hurt;
            Debug.Log($"我是{Monster.name} 我受{Monster.hurt}傷害! 剩下{Monster.hp}點");
        }
    }

    public void Attack(string ButtonName)
    {
        if (ButtonName == "玩家")
        {
            Monster.hp = Monster.hp - Player.hurt;
            Debug.Log($"{Player.name}對{Monster.name}發起攻擊! 造成了{Player.hurt}點傷害!{Monster.name}現在剩下{Monster.hp}點HP");
        }
        else if (ButtonName == "怪物")
        {
            Player.hp = Player.hp - Monster.hurt;
            Debug.Log($"{Monster.name}對{Player.name}發起攻擊! 造成了{Monster.hurt}點傷害!{Player.name}現在剩下{Player.hp}點HP");
        }
    }
    public void Conversaction(string ButtonName)
    {
        if (ButtonName == "玩家")
        {
            Debug.Log($"{Player.name}發起了對話");
        }
        else if (ButtonName == "村民")
        {
            Debug.Log($"{People.name}發起了對話");
        }
        else if (ButtonName == "怪物")
        {
            Debug.Log($"{Monster.name}發起了對話");
        }
    }
}
