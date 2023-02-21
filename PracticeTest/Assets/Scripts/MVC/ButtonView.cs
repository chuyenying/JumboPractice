using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    public delegate void TalkToController(Creature creatureClass);
    public event TalkToController talk_Delegate;

    public event TalkToController Hurt_Delegate;

    public event TalkToController Attack_Delegate;

    public event TalkToController Conversaction_Delegate;

    [SerializeField] private GameObject GameObjectPrefabPanel;  //Prefab
    [SerializeField] private List<GameObject> PrefabPanel;      //Prefab Clone
    [SerializeField] private List<Button> buttons;      //Prefab Clone
    [SerializeField] private GameObject Canvas;

    private void Start()
    {

    }

    public void CreatePrefab(Creature creatureClass, Vector3 position) //創建Panel跟排版
    {
        var PrefabPanel_clone = Instantiate(GameObjectPrefabPanel); //生成prefab
        buttons = new List<Button>(PrefabPanel_clone.GetComponentsInChildren<Button>()); //抓取Prefab的button子物件們

        buttons[0].onClick.AddListener(() => talk_Delegate(creatureClass));
        buttons[1].onClick.AddListener(() => Hurt_Delegate(creatureClass));
        buttons[2].onClick.AddListener(() => Attack_Delegate(creatureClass));
        buttons[3].onClick.AddListener(() => Conversaction_Delegate(creatureClass));

        buttons.Clear();

        //調整prefab的位置
        PrefabPanel_clone.GetComponent<PanelComponent>().PanelText.text = creatureClass.name;
        PrefabPanel_clone.transform.SetParent(Canvas.transform);
        PrefabPanel_clone.transform.localPosition = position;
        PrefabPanel.Add(PrefabPanel_clone);
    }

    public void Output(string DebugLog_View)
    {
        Debug.Log(DebugLog_View);
    }
}
