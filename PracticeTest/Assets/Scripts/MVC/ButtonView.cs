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



    [SerializeField] private List<PanelComponent> panelComponent = new List<PanelComponent>();

    public Action<int> Talk_Controller;

    public void CreatePrefab(Creature creatureClass) //創建Panel跟排版
    {

        panelComponent.Add(Instantiate(GameObjectPrefabPanel, position, new Quaternion(0f, 0f, 0f, 0f), Canvas.transform).GetComponent<PanelComponent>());   // 抓取PanelCompoent元件並新增到List裡

        var _prefabIndex = creatureClass.creature;

        panelComponent[_prefabIndex].PrefabIndex = _prefabIndex;
        panelComponent[_prefabIndex].SetTitleName(creatureClass.name);

        for (int i = 0; i < panelComponent[_prefabIndex].buttons.Count; i++)
        {
            if (creatureClass.mode[i])
            {
                panelComponent[_prefabIndex].buttons[i].onClick.AddListener(() => { Talk_Controller(panelComponent[_prefabIndex].PrefabIndex); });
            }
            else
            {
                panelComponent[_prefabIndex].buttons[i].gameObject.SetActive(false);
            }
        }

        position += Interval;
    }

    public void Output(string DebugLog_View)
    {
        Debug.Log(DebugLog_View);
    }


}
