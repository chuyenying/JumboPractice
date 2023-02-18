using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    public delegate void TalkToController(GameObject creature);
    public event TalkToController talk_Delegate;

    public event TalkToController Hurt_Delegate;

    public event TalkToController Attack_Delegate;

    public event TalkToController Conversaction_Delegate;

    [SerializeField] private GameObject GameObjectPrefabPanel;  //Prefab
    [SerializeField] private List<GameObject> PrefabPanel;      //Prefab Clone
    [SerializeField] private GameObject Canvas;

    private void Start()
    {
        //for (int i=0 ; i< PrefabPanel.Count; i++)
        //{
        //    var buttons = PrefabPanel[i].GetComponent<PanelComponent>().buttons;
        //    foreach (Button _button in buttons)
        //    {
        //        Debug.Log($"test{i}");
        //        _button.onClick.AddListener(() => { talk_Delegate(PrefabPanel[i]); });
        //    }
        //}
    }

    public void CreatePrefab(string creatureName, Vector3 position) //創建Panel跟排版
    {
        var PrefabPanel_clone = Instantiate(GameObjectPrefabPanel);
        PrefabPanel_clone.GetComponent<PanelComponent>().PanelText.text = creatureName;
        PrefabPanel_clone.transform.SetParent(Canvas.transform);
        PrefabPanel_clone.transform.localPosition = position;
        PrefabPanel.Add(PrefabPanel_clone);
    }

    public void Output(string DebugLog_View)
    {
        Debug.Log(DebugLog_View);
    }
}
