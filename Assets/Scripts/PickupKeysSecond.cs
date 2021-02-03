using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKeysSecond : MonoBehaviour
{
    public PickupObjectBaseball ball;
    public List<string> captions;
    public UIControl uiControl;
    public bool hasCarKey = false;
    public bool canBeClicked = false;
    public void GrabSecondCarKey()
    {

        if (canBeClicked)
        {
            hasCarKey = true;
            // Tell the inventory the player has the car key
            DialogueControl.main.AddCaption(captions);

            Inventory.main.hasSecondKey = true;
            //Destroy(gameObject);
        }
        
        
    }
}
