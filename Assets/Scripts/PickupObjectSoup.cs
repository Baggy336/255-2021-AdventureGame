using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectSoup : MonoBehaviour
{
    public DisplayText soupText;
    public UIControl uiControl;
    public void GrabSoup()
    {
        // Tell the inventory the player has the frame
        soupText.ShowTextSoup();
        Inventory.main.hasSoup = true;
        //Destroy(gameObject);
    }
}
