using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Creature
{
    [Header("Creature基本資料")]
    public string name;
    public int hp;
    public int attack;
    public int creature;

    [Header("Mode")]
    public bool Talk;
    public bool Hurt;

    public bool Attack;
    public bool Conversaction;
    
}


