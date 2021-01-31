using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public PickupObjectScript script;
    public PickupDogTags tags;
    public GiveDogTags giveTags;
    
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
    public void ShowTextScript()
    {
        if (script.clickedScript && !previousText.enabled)
        {
            
            myText.enabled = true;
            
        }
        
    }
    public void ShowTextGrabTags()
    {
        if (tags.clickedTags && !previousText.enabled)
        {
            myText.enabled = true;
        }
    }
    public void ShowTextClickBody()
    {
        if (!giveTags.hasTags && !previousText.enabled) myText.enabled = true;
        
    }
    public void ShowTextTagsOnBody()
    {
        if (giveTags.hasTags && !previousText.enabled) myText.enabled = true;
    }
}
