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
        modelController.CreatePrefab_Action = (Creature creatureClass) =>
        {
            buttonView.CreatePrefab(creatureClass); //三個class，則呼叫三次
        };  //建立Prefab

        buttonView.Talk_Controller = (int _PrefabIndex) =>
        {
            buttonView.Output(modelController.Talk(_PrefabIndex));
        };

        buttonView.Attack_Controller = (int MainAttacker, int WhoisAttacked) =>
        {
            buttonView.Output(modelController.Attack(MainAttacker, WhoisAttacked));
        };

        modelController.Init();
    }
}
