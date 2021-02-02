using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectBatteries : MonoBehaviour
{
    public DisplayText script;
    
    public void GrabBatteries()
    {
        // Tell the inventory the player has the batteries
        Inventory.main.hasBatteries = true;
        
        script.ShowTextBatteries();
        Destroy(gameObject);
    }
}
