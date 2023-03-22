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
        Conversaction
    }

    [SerializeField] private GameObject GameObjectPrefabPanel;  //Prefab

    [SerializeField] private GameObject Canvas;

    [SerializeField] private Vector3 position;
    [SerializeField] private Vector3 Interval;



    [SerializeField] private List<PanelComponent> panelComponent = new List<PanelComponent>();

    public Action<int> Talk_Controller;
    public Action<int, bool> Attack_Controller;


    public void CreatePrefab(Creature creatureClass) //創建Panel跟排版
    {
        var Prefab = Instantiate(GameObjectPrefabPanel,
            position,
            new Quaternion(0f, 0f, 0f, 0f),
            Canvas.transform).GetComponent<PanelComponent>();

        var _prefabIndex = creatureClass.creature;

        Prefab.PrefabIndex = _prefabIndex;
        Prefab.SetTitleName(creatureClass.name);

        for (int i = 0; i < panelComponent[_prefabIndex].buttons.Count; i++)
        {
            switch (i)
            {
                case (int)Mode_Action.Talk: //第一個button根據
                    {
                        if (creatureClass.Talk)
                        {
                            Prefab.buttons[i].onClick.AddListener(() => { Talk_Controller(_prefabIndex); });
                        }
                        else
                        {
                            Prefab.CloseUI(Prefab.buttons[i].gameObject);
                        }
                        break;
                    }

                case (int)Mode_Action.Hurt:
                    {
                        if (creatureClass.Hurt)
                        {
                            
                        }
                        else
                        {
                            Prefab.CloseUI(Prefab.buttons[i].gameObject);
                        }
                        break;
                    }

                case (int)Mode_Action.Attack:   //方便知道呼叫哪個Action
                    {
                        if (creatureClass.Attack)       //Model的資料得知有沒有Attack功能
                        {
                            if (creatureClass.ShowNicePerson_Toggle == false)
                            {
                                Prefab.CloseUI(Prefab.toggle.gameObject);
                            }

                            Prefab.buttons[i].onClick.AddListener(() => { Attack_Controller(_prefabIndex, Prefab.toggle.isOn); });
                        }
                        else
                        {
                            Prefab.CloseUI(Prefab.buttons[i].gameObject);
                        }
                        break;
                    }

                case (int)Mode_Action.Conversaction:
                    {
                        if (creatureClass.Conversaction)
                        {
                          
                        }
                        else
                        {
                            Prefab.CloseUI(Prefab.buttons[i].gameObject);
                        }
                        break;
                    }
            }
        }

        position += Interval;
        panelComponent.Add(Prefab);   // 抓取PanelCompoent元件並新增到List裡
    }

    public void Output(string DebugLog_View)
    {
        Debug.Log(DebugLog_View);
    }


}
