using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{

    [SerializeField] private GameObject GameObjectPrefabPanel;  //Prefab
    [SerializeField] private List<GameObject> GameObjectPrefabPanelList;  //Prefab
    [SerializeField] private GameObject Canvas;
    [SerializeField] private Vector3 position;
    [SerializeField] private Vector3 Interval;

    //public delegate void TalkToController(Creature creatureClass);
    //public event TalkToController talk_Delegate;

    //public event TalkToController Hurt_Delegate;

    //public event TalkToController Attack_Delegate;

    //public event TalkToController Conversaction_Delegate;

    public Action CloseButton;

    public void CreatePrefab(Creature creatureClass) //創建Panel跟排版
    {
        var PrefabPanel_clone = Instantiate(GameObjectPrefabPanel); //生成prefab

        PrefabPanel_clone.transform.SetParent(Canvas.transform);
        PrefabPanel_clone.transform.localPosition = position;
        position += Interval;
        GameObjectPrefabPanelList.Add(PrefabPanel_clone);
    }

    public void Output(string DebugLog_View)
    {
        Debug.Log(DebugLog_View);
    }
}
