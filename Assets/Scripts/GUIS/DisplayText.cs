using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public PickupObjectScript script;
    
    
    public UIControl uiText;

    public Text myText;
    public Text previousText;
    public Text nextText;
    public Text introText;

    public float textTimer = 4;
    
    

    private void Start()
    {
        previousText.enabled = false;
        myText.enabled = false;
        introText.enabled = true;
    }

    private void Update()
    {

        if (myText.enabled && ((Input.GetButtonDown("Fire2"))))
        {
            nextText.enabled = true;
            myText.enabled = false;
            introText.enabled = false;

        }

    }
    public void ShowText()
    {
        if (script.clickedScript && !previousText.enabled)
        {
            
            myText.enabled = true;
            
        }


    }
}
