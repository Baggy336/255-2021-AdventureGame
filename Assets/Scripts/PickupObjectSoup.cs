using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectSoup : MonoBehaviour
{
    public List<string> captions;
    public UIControl uiControl;
    public void GrabSoup()
    {
        // Tell the inventory the player has the frame
        DialogueControl.main.AddCaption(captions);
        Inventory.main.hasSoup = true;
        //Destroy(gameObject);
        Destroy(gameObject);
    }
}
