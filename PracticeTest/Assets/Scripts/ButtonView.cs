using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    public int creature;
    public bool isTalk = false;

    //talk
    public void Player_talk()
    {
        isTalk = true;
        creature = 0;
    }
    public void People_talk()
    {
        isTalk = true;
        creature = 1;
    }
    public void Monster_talk()
    {
        isTalk = true;
        creature = 2;
    }

    //Hurt
    public void Player_Hurt()
    {
        isTalk = true;
        creature = 0;
    }
    public void People_Hurt()
    {

    }
    public void Monster_Hurt()
    {

    }

    // Attacl
    public void Player_Attack()
    {
        isTalk = true;
        creature = 0;
    }
    public void Monster_Attack()
    {

    }

    public void Output(string DebugLog_View)
    {
        Debug.Log(DebugLog_View);
    }
}
