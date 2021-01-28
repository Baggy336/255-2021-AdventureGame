using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectCarKey : MonoBehaviour
{
    public void GrabCarKey()
    {
        // Tell the inventory the player has the car key
        Inventory.main.hasSpareCarKey = true;
        Destroy(gameObject);
    }
}
