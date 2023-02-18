using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelComponent : MonoBehaviour
{
    public Text PanelText;
    public List<Button> buttons;

    private void Start()
    {
        if(PanelText.text == "村民")
        {
            buttons[2].gameObject.SetActive(false);
        }else if(PanelText.text == "怪物")
        {
            buttons[3].gameObject.SetActive(false);
        }
    }
}
