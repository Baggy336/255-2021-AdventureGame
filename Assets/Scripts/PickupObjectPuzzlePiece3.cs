using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectPuzzlePiece3 : MonoBehaviour
{
    public void GrabPiece3()
    {
        // Tell the inventory the player has the second piece
        Inventory.main.hasPuzzlePiece3 = true;
        Destroy(gameObject);
    }
}

