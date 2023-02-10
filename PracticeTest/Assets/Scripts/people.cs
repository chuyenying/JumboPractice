using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : Creature, I_Conversaction
{

    public override void set()
    {
        name = "村民";
        hp = 8;
        hurt = 3;
    }


    public void Conversaction()
    {
        Debug.Log($"{getName()}發起了聊天!");
    }

}
