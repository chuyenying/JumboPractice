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

    [Header("CreaturePanel Prefab")]
    [SerializeField] private GameObject GameObjectPrefabPanel;  //Prefab
    [SerializeField] private GameObject Prefab_Panel;

    [Header("PanelComponent-CreaturePanel Prefab")]
    [SerializeField] private List<PanelComponent> panelComponent = new List<PanelComponent>();

    public Action<int> Talk_Controller;
    public Action<int, int> Attack_Controller;

    public Vector2 Position, Interval;
    private int Main_Attack;

    public void CreatePrefab(Creature creatureClass) //創建Panel跟排版
    {
        panelComponent.Add(Instantiate(GameObjectPrefabPanel, Position, new Quaternion(0f, 0f, 0f, 0f), Prefab_Panel.transform).GetComponent<PanelComponent>());   // 抓取PanelCompoent元件並新增到List裡
        //panelComponent.Add(Instantiate(GameObjectPrefabPanel, Prefab_Canvas.transform).GetComponent<PanelComponent>());   // 抓取PanelCompoent元件並新增到List裡

        var Prefab = panelComponent[creatureClass.creature];

        Prefab.PrefabIndex = creatureClass.creature;

        Prefab.SetTitleName(creatureClass.name);

        if (creatureClass.Talk)
        {
            Prefab.Buttons[(int)Mode_Action.Talk].onClick.AddListener(() => { Talk_Controller(Prefab.PrefabIndex); });
        }
        else
        {
            Prefab.CloseTalkButton();
        }

        if (creatureClass.Hurt)
        {

        }
        else
        {
            Prefab.CloseHurtButton();
        }

        if (creatureClass.Attack)       //Model的資料得知有沒有Attack功能
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

        Prefab.Buttons[(int)Mode_Action.WhoisAttacked].onClick.AddListener(() => { Attack_Controller(Main_Attack, creatureClass.creature); });

        if (creatureClass.Conversaction)
        {

        }
        else
        {
            Prefab.CloseConversactionButton();
        }
        Position += Interval;
    }

    public void Output(string DebugLog_View)
    {
        Debug.Log(DebugLog_View);
    }


}
