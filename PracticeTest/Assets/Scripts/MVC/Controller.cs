using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Controller : MonoBehaviour
{
    [SerializeField] private ModelController modelController;
    [SerializeField] private ButtonView buttonView;

    private void Awake()
    {
        modelController.PlayerDelegate += LetViewCreatePrefab;  //建立Prefab的委派event
        buttonView.talk_Delegate += talk;  //建立Prefab的委派event
        buttonView.Hurt_Delegate += Hurt;  
        buttonView.Attack_Delegate += Attack;  
        buttonView.Conversaction_Delegate += Conversaction;  
    }

    public void LetViewCreatePrefab(Creature creatureClass, Vector3 position)
    {
        buttonView.CreatePrefab(creatureClass, position);
    }

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
}
