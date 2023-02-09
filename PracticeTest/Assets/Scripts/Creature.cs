using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    [SerializeField] private string name;
    protected int hp;
    protected int hurt;
    private int test;
    public int Test
    {
        get { return test; }
        //set { test = value; }
    }
    private void Start()
    {
        set();
    }

    public virtual void set()
    {
        name = "";
        hp = 0;
        hurt = 0;
    }

    public int getHurt()
    {
        return hurt;
    }

    public string getName()
    {
        return name;
    }

    public int getHp()
    {
        return hp;
    }

    public void TalkButton()
    {
        Debug.Log($"我是{getName()} 我有{getHp()}點HP");
    }

    public void Hurt()
    {
        hp -= hurt;

        if (hp <= 0)
        {
            Debug.Log($"{getName()}受傷了!，扣了{getHurt()}點HP，死掉ㄌ");
        }
        else
        {
            Debug.Log($"{getName()}受傷了!，扣了{getHurt()}點HP，還剩{getHp()}點HP");
        }
    }
}
