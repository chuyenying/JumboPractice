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
        buttonView.talk_Delegate += AskModelOutputString;  //建立Prefab的委派event
    }
    
    public void LetViewCreatePrefab(string creatureName ,Vector3 position)
    {
        buttonView.CreatePrefab(creatureName,position);
    }

    public void AskModelOutputString(GameObject creature)
    {

    }
}
