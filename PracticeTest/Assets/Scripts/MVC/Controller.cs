using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Controller : MonoBehaviour
{
    [SerializeField] private ModelController modelController;
    [SerializeField] private ButtonView buttonView;
    [SerializeField] private PanelComponent panelComponent;

    private void Awake()
    {
        modelController.CreatePrefab_Delegate = (Creature creatureClass , int PrefabIndex) =>
        {
            buttonView.CreatePrefab(creatureClass);
        };  //建立Prefab

        modelController.TellViewToCloseWhichButton = (bool[] ButtonNum) => {  };  //關閉Button

        modelController.Init();

        //buttonView.talk_Delegate += talk;
        //buttonView.Hurt_Delegate += Hurt;
        //buttonView.Attack_Delegate += Attack;
        //buttonView.Conversaction_Delegate += Conversaction;
    }

    #region CreatureMode
    public void talk(Creature creatureClass)
    {
        buttonView.Output(modelController.Talk(creatureClass));
    }
    public void Hurt(Creature creatureClass)
    {
        buttonView.Output(modelController.Hurt(creatureClass));
    }
    public void Attack(Creature creatureClass)
    {
        buttonView.Output(modelController.Attack(creatureClass));
    }
    public void Conversaction(Creature creatureClass)
    {
        buttonView.Output(modelController.Conversaction(creatureClass));
    }

    #endregion
}
