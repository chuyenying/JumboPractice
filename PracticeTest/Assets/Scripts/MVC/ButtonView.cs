using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{

    [SerializeField] private GameObject GameObjectPrefabPanel;  //Prefab

    [SerializeField] private GameObject Canvas;

    [SerializeField] private Vector3 position;
    [SerializeField] private Vector3 Interval;



    private PanelComponent panelComponent;

    public Action<int> Talk_Controller;

    public void CreatePrefab(Creature creatureClass) //創建Panel跟排版
    {
        var PrefabPanel_clone = Instantiate(GameObjectPrefabPanel); //生成prefab

        panelComponent = (PrefabPanel_clone.GetComponent<PanelComponent>());   // 抓取PanelCompoent元件並新增到List裡
        
        panelComponent.PrefabIndex = creatureClass.creature;
        panelComponent.SetTitleName(creatureClass.name);
        panelComponent.CloseButton(panelComponent.PrefabIndex, creatureClass.mode);

        panelComponent.Talk_Action = (PanelComponent _panelComponent) => { Talk_Controller(_panelComponent.PrefabIndex); };

        //**************** Prefab排版 ***************

        PrefabPanel_clone.transform.SetParent(Canvas.transform);
        PrefabPanel_clone.transform.localPosition = position;
        position += Interval;

        //********************************************
    }

    public void Output(string DebugLog_View)
    {
        Debug.Log(DebugLog_View);
    }


}
