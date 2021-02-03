using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectWardrobeKey : MonoBehaviour
{
    public UIControl uiControl;
    
    public void GrabKey()
    {
        // Tell the inventory the player has the wardrobe key
        Inventory.main.hasWardrobeKey = true;
        
        
        if (Inventory.main.hasWardrobeKey)
        {
            Destroy(gameObject);

        }

        
        

        
    }
}
