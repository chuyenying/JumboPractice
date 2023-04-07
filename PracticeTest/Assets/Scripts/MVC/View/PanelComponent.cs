using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelComponent : MonoBehaviour
{
    public enum ButtonMode
    {
        Talk,
        Hurt,
        Attack,
        Conversaction,
        WhoisAttacked
    }

    [SerializeField] private Text PanelText;
    [SerializeField] private List<Button> buttons;

    private int prefabIndex;

    private bool IsSetPrefabIndex = false;

    #region Set、Get

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

    public List<Button> Buttons
    {
        get
        {
            return buttons;
        }
    }

    #endregion

    public void SetTitleName(string name)
    {
        this.PanelText.text = name;
        this.gameObject.name = name;
    }

    #region CloseModeButton

    
    public void CloseTalkButton()
    {
        buttons[(int)ButtonMode.Talk].gameObject.SetActive(false);
    }

    public void CloseHurtButton()
    {
        buttons[(int)ButtonMode.Hurt].gameObject.SetActive(false);
    }

    public void CloseAttackButton()
    {
        buttons[(int)ButtonMode.Attack].gameObject.SetActive(false);
    }

    public void CloseConversactionButton()
    {
        buttons[(int)ButtonMode.Conversaction].gameObject.SetActive(false);
    }

    public void Close_WhoIsAttackedButton()
    {
        buttons[(int)ButtonMode.WhoisAttacked].gameObject.SetActive(false);
    }
    #endregion

    #region OpenModeButton

    public void Open_WhoIsAttackedButton()
    {
        buttons[(int)ButtonMode.WhoisAttacked].gameObject.SetActive(true);
    }
    #endregion
}
