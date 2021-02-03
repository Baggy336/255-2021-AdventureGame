using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBaseballAgain : MonoBehaviour
{
    public List<string> captions;
    public UIControl uiControl;
    public bool clickedBall = false;
    
    public void GrabBaseballAgain()
    {
        // Tell the inventory the player has the baseball
        clickedBall = true;
        Inventory.main.hasBaseball2 = true;
        DialogueControl.main.AddCaption(captions);
        Destroy(gameObject);


    }
}
