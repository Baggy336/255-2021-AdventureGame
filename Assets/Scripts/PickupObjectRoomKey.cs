using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectRoomKey : MonoBehaviour
{
    
    public void GrabObject()
    {
        // Tell the inventory system that the player has a specific object
        Inventory.main.hasRoomKey = true;
        
        // Remove the object from the scene
        Destroy(gameObject);
    }
 
}
