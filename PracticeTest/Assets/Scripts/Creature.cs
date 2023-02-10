using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager:MonoBehaviour
{
    public Creature New_Creature()
    {
        var creature = new Creature();
        return creature;
    }

}

[CreateAssetMenu(fileName ="New Data" , menuName ="Creature/Create Creature" , order =1)]
public class Creature : ScriptableObject
{
    [SerializeField] private string name;
    [SerializeField] private int hp;
    [SerializeField] int hurt;

    /*
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int HP
    {
        get { return hp; }
        set { hp = value; }
    }

    public int Hurt
    {
        get { return hurt; }
        set { hurt = value; }
    }

    private int test;
    public int Test
    {
        get { return test; }
        //set { test = value; }
    }
    
    */
}


