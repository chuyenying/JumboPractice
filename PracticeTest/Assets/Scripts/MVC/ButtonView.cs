using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    public delegate void TalkToController(int creature);
    public event TalkToController talk_Controller;

    public event TalkToController Hurt_Controller;

    public event TalkToController Attack_Controller;

    public event TalkToController Conversaction_Controller;

    [Header("Player")]
    [SerializeField] private Button Player_Talk;
    [SerializeField] private Button Player_Hurt;
    [SerializeField] private Button Player_Attack;
    [SerializeField] private Button Player_Conversaction;

    [Header("People")]
    [SerializeField] private Button People_Talk;
    [SerializeField] private Button People_Hurt;
    [SerializeField] private Button People_Conversaction;

    [Header("Monster")]
    [SerializeField] private Button Monster_Talk;
    [SerializeField] private Button Monster_Hurt;
    [SerializeField] private Button Monster_Attack;


    private void Start()
    {
        Player_Talk.onClick.AddListener(() => { Talk_OnClick(0); }); // 當按下玩家說話按鈕呼叫 OnClick func
        Player_Hurt.onClick.AddListener(() => { Hurt_OnClick(0); });
        Player_Attack.onClick.AddListener(() => { Attack_OnClick(0); });
        Player_Conversaction.onClick.AddListener(() => { Conversaction_OnClick(0); });

        People_Talk.onClick.AddListener(() => { Talk_OnClick(1); }); // 當按下玩家說話按鈕呼叫 OnClick func
        People_Hurt.onClick.AddListener(() => { Hurt_OnClick(1); });
        People_Conversaction.onClick.AddListener(() => { Conversaction_OnClick(1); });

        Monster_Talk.onClick.AddListener(() => { Talk_OnClick(2); }); // 當按下玩家說話按鈕呼叫 OnClick func
        Monster_Hurt.onClick.AddListener(() => { Hurt_OnClick(2); });
        Monster_Attack.onClick.AddListener(() => { Attack_OnClick(2); });
    }

    public void Talk_OnClick(int creature)
    {
        talk_Controller(creature);  //觸發event
    }
    public void Hurt_OnClick(int creature)
    {
        Hurt_Controller(creature);
    }
    public void Attack_OnClick(int creature)
    {
        Attack_Controller(creature);
    }
    public void Conversaction_OnClick(int creature)
    {
        Conversaction_Controller(creature);
    }


    public void Output(string DebugLog_View)
    {
        Debug.Log(DebugLog_View);
    }
}
