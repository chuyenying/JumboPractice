using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Creature ,Interface.I_Attack, Interface.I_Conversaction
{

    public override void set()
    {
        name = "玩家";
        hp = 10;
        hurt = 2;
    }


    public void Attack()
    {
        Debug.Log($"{getName()}發起了攻擊!");
    }

    public void Conversaction()
    {
        Debug.Log($"{getName()}發起了聊天!");
    }
}
