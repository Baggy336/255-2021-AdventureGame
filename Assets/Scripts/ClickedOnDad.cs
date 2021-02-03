using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedOnDad : MonoBehaviour
{
    public UIControl uiControl;
    public PickupBaseballAgain ball2;
    public List<string> captions;
    public bool clickedDad = false;

    public void ThrowBall()
    {
        if (Inventory.main.hasBaseball2)
        {
            clickedDad = true;
            DialogueControl.main.AddCaption(captions);
        }
        
    }
}
