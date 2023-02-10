using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller:MonoBehaviour
{
    private Button Player_Talk;

    private void Awake()
    {
        Player_Talk = gameObject.GetComponent<ButtonView>().Player_Talk;
    }
    private void Start()
    {
        
        Player_Talk.onClick.AddListener(test);
    }

    private void Update()
    {
       
    }

    public void test() { Debug.Log("test"); }
}
