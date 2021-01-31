using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public PickupObjectScript script;
    public UIControl uiText;

    public Text myText;

    public float textTimer = 5;
    public float timeToDisappear;

    private void Start()
    {
        myText.enabled = false;
    }

    private void Update()
    {
        
        if(myText.enabled && (Time.time >= timeToDisappear))
        {
            
            myText.enabled = false;

        }

    }
    public void ShowText()
    {
        if (script.clickedScript)
        {
            
            myText.enabled = true;
            timeToDisappear = Time.time + textTimer;
        }
    }
}
