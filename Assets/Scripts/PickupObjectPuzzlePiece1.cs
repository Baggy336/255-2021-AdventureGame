using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectPuzzlePiece1 : MonoBehaviour
{
    public void GrabPiece1()
    {
        // Tell the inventory the player has the first puzzle piece
        Inventory.main.hasPuzzlePiece1 = true;
        // Remove the asset
        Destroy(gameObject);
    }
}
