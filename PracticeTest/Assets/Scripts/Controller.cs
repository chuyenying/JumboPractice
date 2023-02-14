using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Controller : MonoBehaviour
{
    string TalkParameter;
    string ButtonName;

    public void GetCurrentButtonName()
    {
        ButtonName = "";
        TalkParameter = "";
        ButtonName = EventSystem.current.currentSelectedGameObject.name;
        TalkParameter = ButtonName[0].ToString() + ButtonName[1].ToString();
    }

    public void CallFunc_Talk()
    {
        GetCurrentButtonName();
        GameObject.Find("ButtonView").GetComponent<ButtonView>().Talk(TalkParameter);
    }

    public void CallFunc_Hurt()
    {
        GetCurrentButtonName();
        GameObject.Find("ButtonView").GetComponent<ButtonView>().Hurt(TalkParameter);
    }
    public void CallFunc_Attack()
    {
        GetCurrentButtonName();
        GameObject.Find("ButtonView").GetComponent<ButtonView>().Attack(TalkParameter);
    }
    public void CallFunc_Conversaction()
    {
        GetCurrentButtonName();
        GameObject.Find("ButtonView").GetComponent<ButtonView>().Conversaction(TalkParameter);
    }
}
