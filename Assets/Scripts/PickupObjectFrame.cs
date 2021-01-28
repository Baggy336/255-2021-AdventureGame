using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectFrame : MonoBehaviour
{
    public void GrabFrame()
    {
        // Tell the inventory the player has the frame
        Inventory.main.hasElectronicFrame = true;
        Destroy(gameObject);
    }
}
