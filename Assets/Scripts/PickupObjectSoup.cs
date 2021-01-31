using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectSoup : MonoBehaviour
{
    public void GrabSoup()
    {
        // Tell the inventory the player has the frame
        Inventory.main.hasSoup = true;
        Destroy(gameObject);
    }
}
