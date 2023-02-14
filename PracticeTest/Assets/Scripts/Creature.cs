using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Data", menuName = "Creature/Create Creature", order = 1)]
public class Creature : ScriptableObject
{
    public string name;
    public int hp;
    public int hurt;
}


