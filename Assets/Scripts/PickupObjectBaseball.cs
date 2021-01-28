using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectBaseball : MonoBehaviour
{
    public void GrabBaseball()
    {
        // Tell the inventory the player has the baseball
        Inventory.main.hasBaseball = true;
        Destroy(gameObject);
    }
}
