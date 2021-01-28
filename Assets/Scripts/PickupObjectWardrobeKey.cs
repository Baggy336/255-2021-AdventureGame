using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectWardrobeKey : MonoBehaviour
{
    public void GrabKey()
    {
        // Tell the inventory the player has the wardrobe key
        Inventory.main.hasWardrobeKey = true;
        Destroy(gameObject);
    }
}
