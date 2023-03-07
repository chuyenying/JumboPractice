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

    public List<PanelComponent> panelComponent;

    public Action CloseButton;

    public void CreatePrefab(Creature creatureClass) //創建Panel跟排版
    {
        var PrefabPanel_clone = Instantiate(GameObjectPrefabPanel); //生成prefab

        panelComponent.Add(PrefabPanel_clone.GetComponent<PanelComponent>());

        PrefabPanel_clone.transform.SetParent(Canvas.transform);
        PrefabPanel_clone.transform.localPosition = position;
        position += Interval;

        panelComponent[panelComponent.Count - 1].PrefabIndex = panelComponent.Count - 1;
    }

    public void Output(string DebugLog_View)
    {
        Debug.Log(DebugLog_View);
    }


}
