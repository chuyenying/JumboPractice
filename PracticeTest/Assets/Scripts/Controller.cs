using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private ButtonView buttonView;

    public void CallFunc_Talk()
    {
        buttonView.Talk();
    }
}
