using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectKeepsake : MonoBehaviour
{
    public void GrabKeepsake()
    {
        // Tell the inventory the player has the keepsake
        Inventory.main.hasKeepsake = true;
        Destroy(gameObject);
    }
}
