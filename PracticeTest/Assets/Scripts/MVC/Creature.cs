using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Creature", menuName ="Create Creature", order =1)]
public class Creature :ScriptableObject
{
    public string name;
    public int hp;
    public int attack;
    public int creature;

    /// <summary> mode分別代表
    /// [0]:說話、[1]:受傷、[2]:攻擊、[3]:對話
    /// </summary>
    public bool[] mode = new bool [4];
}


