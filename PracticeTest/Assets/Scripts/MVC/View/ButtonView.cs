using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    public enum Mode_Action
    {
        Talk,
        Hurt,
        Attack,
        Conversaction,
        WhoisAttacked
    }
    private int Main_Attack;

    [Header("CreaturePanel Prefab")]
    [SerializeField] private GameObject GameObjectPrefabPanel;  //Prefab
    [SerializeField] private GameObject Prefab_Panel;

    [Header("UI can be Interact")]
    [SerializeField] private List<PanelComponent> panelComponent = new List<PanelComponent>();

    [SerializeField] private Button ResetButton;

    [Header("Prefab LocalPosition")]
    [SerializeField] private Vector2 Position;
    [SerializeField] private Vector2 Interval;

    public Action<int> Talk_Controller;
    public Action<int, int> Attack_Controller;
    public Action ResetAction;

    public void Init()
    {
        ResetButton.onClick.AddListener(() => { ResetAction?.Invoke(); });
    }

    public void CreatePrefab(Creature CreatureClass) //創建Panel跟排版
    {
        panelComponent.Add(Instantiate(GameObjectPrefabPanel, Position, new Quaternion(0f, 0f, 0f, 0f), Prefab_Panel.transform).GetComponent<PanelComponent>());   // 抓取PanelCompoent元件並新增到List裡

        var Prefab = panelComponent[(int)CreatureClass.creature];

        Prefab.PrefabIndex = (int)CreatureClass.creature;

        Prefab.SetTitleName(CreatureClass.name);

        #region Talk
        if (CreatureClass.Talk)
        {
            Prefab.GetButton(Buu.Talk).onClick.AddListener(() => { Talk_Controller((int)CreatureClass.creature); });
        }
        else
        {
            Prefab.CloseTalkButton();
        }
        #endregion

        #region Hurt
        if (CreatureClass.Hurt)
        {

        }
        else
        {
            Prefab.CloseHurtButton();
        }
        #endregion

        #region Attack

        if (CreatureClass.Attack)       //Model的資料得知有沒有Attack功能
        {
            Prefab.Buttons[(int)Mode_Action.Attack].onClick.AddListener(() =>
            {
                for (int i = 0; i < panelComponent.Count; i++)
                {
                    if (i == Prefab.PrefabIndex)
                    {
                        Main_Attack = i;
                        Prefab.Close_WhoIsAttackedButton();
                    }
                    else
                    {
                        panelComponent[i].Open_WhoIsAttackedButton();
                    }
                }
            });
        }
        else
        {
            Prefab.CloseAttackButton();
        }

        Prefab.Buttons[(int)Mode_Action.WhoisAttacked].onClick.AddListener(() => { Attack_Controller(Main_Attack, (int)CreatureClass.creature); });

        #endregion

        #region Conversaction
        if (CreatureClass.Conversaction)
        {

        }
        else
        {
            Prefab.CloseConversactionButton();
        }
        #endregion

        Position += Interval;
    }

    public void Output(string DebugLog_View)
    {
        Debug.Log(DebugLog_View);
    }
}
