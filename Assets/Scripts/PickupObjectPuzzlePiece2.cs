using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectPuzzlePiece2 : MonoBehaviour
{
    public void GrabPiece2()
    {
        // Tell the inventory the player has the second piece
        Inventory.main.hasPuzzlePiece2 = true;
        Destroy(gameObject);
    }
}
