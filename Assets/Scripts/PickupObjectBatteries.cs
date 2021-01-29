using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectBatteries : MonoBehaviour
{
    public void GrabBatteries()
    {
        // Tell the inventory the player has the batteries
        Inventory.main.hasBatteries = true;
        Destroy(gameObject);
    }
}
