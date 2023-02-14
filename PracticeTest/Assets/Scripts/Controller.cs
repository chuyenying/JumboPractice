using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//controller 跟 model 抓取資料 --> model邏輯判斷結束回傳資料{確認是哪個生物、取得生物的資料、邏輯運算得到一個輸出結果} -->由controller傳一個string給view
public class Controller : MonoBehaviour
{
    public ModelController modelController;
    public ButtonView buttonView;

    public void CallFunc_Talk(string creature)
    {
        string DebugLog_View = modelController.Talk(creature);
        buttonView.Output(DebugLog_View);
    }
    public void CallFunc_Hurt(string creature)
    {
        string DebugLog_View = modelController.Hurt(creature);
        buttonView.Output(DebugLog_View);
    }
    public void CallFunc_Attack(string creature)
    {
        string DebugLog_View = modelController.Attack(creature);
        buttonView.Output(DebugLog_View);
    }
    public void CallFunc_Conversaction(string creature)
    {
        string DebugLog_View = modelController.Conversaction(creature);
        buttonView.Output(DebugLog_View);
    }
}
