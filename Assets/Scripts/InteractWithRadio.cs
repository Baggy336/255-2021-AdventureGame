using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithRadio : MonoBehaviour
{
    public PickupObjectPuzzlePiece1 puzzle;
    public UIControl uiControl;
    public DisplayText script;

    public void InteractRadio()
    {
        if (Inventory.main.hasBatteries) script.ShowTextRadio();
        puzzle.canBeClicked = true;
    }
}
