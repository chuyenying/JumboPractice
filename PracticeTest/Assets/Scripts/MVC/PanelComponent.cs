using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelComponent : MonoBehaviour
{
    [SerializeField] public Text PanelText;
    [SerializeField] public List<Button> buttons;

    private int prefabIndex;

    private bool IsSetPrefabIndex = false;

    public int PrefabIndex
    {
        get
        {
            return prefabIndex;
        }

        set
        {
            if (!IsSetPrefabIndex)
            {
                prefabIndex = value;
                IsSetPrefabIndex = true;
            }
        }
    }

    /*
    public void InitButton(int View_PrefabIndex, bool[] Mode)
    {
        if (this.PrefabIndex == View_PrefabIndex)
        {
            for (int i = 0; i < Mode.Length; i++)
            {
                if (Mode[i])
                {
                    buttons[i].onClick.AddListener(() => { Talk_Action(this.PrefabIndex); });
                }
                else
                {
                    buttons[i].gameObject.SetActive(false);
                }
            }
        }
    }
    */
    
    public void SetTitleName(string name)
    {
        this.PanelText.text = name;
        this.gameObject.name = name;
    }

}
