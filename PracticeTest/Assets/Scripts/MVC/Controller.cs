using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Controller : MonoBehaviour
{
    [SerializeField] private ModelController modelController;
    [SerializeField] private ButtonView buttonView;

    private void Start()
    {
        buttonView.talk_Controller += Talk;
        buttonView.Hurt_Controller += Hurt;
        buttonView.Attack_Controller += Attack;
        buttonView.Conversaction_Controller += Conversaction;
    }

    public void Talk(int creature)
    {
        buttonView.Output(modelController.Talk(creature));
    }
    public void Hurt(int creature)
    {
        buttonView.Output(modelController.Hurt(creature));
    }
    public void Attack(int creature)
    {
        buttonView.Output(modelController.Attack(creature));
    }
    public void Conversaction(int creature)
    {
        buttonView.Output(modelController.Conversaction(creature));
    }
}
