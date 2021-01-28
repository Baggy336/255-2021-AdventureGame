using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectPianoTuner : MonoBehaviour
{
    public void GrabPianoTuner()
    {
        // Tell the inventory the player has the piano tuner
        Inventory.main.hasPianoTuner = true;
        Destroy(gameObject);
    }
}
