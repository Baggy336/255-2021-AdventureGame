using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBaseballAgain : MonoBehaviour
{
    public DisplayText script;
    public UIControl uiControl;
    public bool clickedBall = false;
    
    public void GrabBaseballAgain()
    {
        // Tell the inventory the player has the baseball
        clickedBall = true;
        Inventory.main.hasBaseball2 = true;
        script.ShowBaseball2Text();
        Destroy(gameObject);


    }
}
