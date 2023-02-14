using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCreature
{
    public Creature Player;
    public Creature People;
    public Creature Monster;

    public NewCreature()
    {
        Player.name = "玩家";
        Player.hp = 10;
        Player.attack = 2;

        People.name = "村民";
        People.hp = 8;
        People.attack = 1;

        Monster.name = "怪物";
        Monster.hp = 12;
        Monster.attack = 3;
    }
}
