using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{

    public  delegate void Creature_Delegate();
    public event Creature_Delegate creature_Delegate;

    public void Output(string DebugLog_View)
    {
        Debug.Log(DebugLog_View);
    }
}
