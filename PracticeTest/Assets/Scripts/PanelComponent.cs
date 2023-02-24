using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelComponent : MonoBehaviour
{
    public Text PanelText;
    public List<Button> buttons;

    public delegate void TalkToController(Creature creatureClass);
    public event TalkToController talk_Delegate;

    public event TalkToController Hurt_Delegate;

    public event TalkToController Attack_Delegate;

    public event TalkToController Conversaction_Delegate;

    public Action closeButton;

    private void Init()
    {
        //buttons[0].onClick.AddListener(() => talk_Delegate());
        //buttons[1].onClick.AddListener(() => Hurt_Delegate());
        //buttons[2].onClick.AddListener(() => Attack_Delegate());
        //buttons[3].onClick.AddListener(() => Conversaction_Delegate());
    }

    public void CloseButton(bool[] buttonNum)
    {

    }
}
