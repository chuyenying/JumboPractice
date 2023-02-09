using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Creature, Interface.I_Attack
{
    public override void set()
    {
        name = "怪物";
        hp = 12;
        hurt = 1;
    }

    public void Attack(){
        Debug.Log($"{getName()}發起了攻擊!");
    }

}
