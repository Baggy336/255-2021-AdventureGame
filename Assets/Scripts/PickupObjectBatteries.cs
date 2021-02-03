using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectBatteries : MonoBehaviour
{
    public List<string> captions;
    
    public void GrabBatteries()
    {
        // Tell the inventory the player has the batteries
        Inventory.main.hasBatteries = true;

        DialogueControl.main.AddCaption(captions);
        Destroy(gameObject);
    }
}
