using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelComponent : MonoBehaviour
{
    public Text PanelText;
    public List<Button> buttons;
    public Toggle toggle;

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


    public void SetTitleName(string name)
    {
        this.PanelText.text = name;
        this.gameObject.name = name;
    }

    public void CloseUI(GameObject PrefabUI)
    {
        PrefabUI.SetActive(false);
    }
}
