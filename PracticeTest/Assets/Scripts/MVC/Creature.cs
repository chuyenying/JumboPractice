using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Creature", menuName = "Create Creature", order = 1)]
public class Creature : ScriptableObject
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

    [Space]
    [Header("Attack的附加功能")]
    public bool ShowNicePerson_Toggle = false;
    
    /*
    [Tooltip("[0]:說話、[1]:受傷、[2]:攻擊、[3]:對話")]
    public bool[] mode = new bool[4];
    */

}


