using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public PickupObjectScript script;
    public PickupDogTags tags;
    public GiveDogTags giveTags;
    public PickupObjectCookingIngredient lemon;
    public PickupKeysSecond secondKey;
    public PickupObjectBaseball baseball;
    public PickupObjectSoup soup;
    public PickupBaseballAgain ball2;
    public ClickedOnDad throwTo;
    public PickupLivingRoomBaseball livingRoomBall;
    public DoorNeedsKey lockedDoor;
    public PickupObjectWardrobeKey wardrobe;
    
    
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
    public void ShowTextLemon()
    {
        if (lemon.grabLemon && !previousText.enabled) myText.enabled = true;
    }
    public void ShowTextSecondCarKey()
    {
        if (secondKey.hasCarKey && !previousText.enabled) myText.enabled = true;
    }
    public void ShowTextBaseball()
    {
        if (baseball.clickedBaseball && !previousText.enabled) myText.enabled = true;
    }
    public void ShowTextSoup()
    {
        if (Inventory.main.hasSoup && !previousText.enabled) myText.enabled = true;
    }
    public void ShowBaseball2Text()
    {
        if (ball2.clickedBall && !previousText.enabled) myText.enabled = true;
    }
    public void ThrowBallToDad()
    {
        if (throwTo.clickedDad && !previousText.enabled) myText.enabled = true;
    }
    public void ShowBaseball3Text()
    {
        if (livingRoomBall.clickedBall && !previousText.enabled) myText.enabled = true;
    }
    public void ShowTextLockedDoor()
    {
        if (Inventory.main.hasRoomKey != true && !previousText.enabled) myText.enabled = true;
    }
    
    public void ShowTextWardrobeKey()
    {
        if (Inventory.main.hasWardrobeKey && !previousText.enabled) myText.enabled = true;
    }
}
