using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithRadio : MonoBehaviour
{
    public PickupObjectPuzzlePiece1 puzzle;
    public UIControl uiControl;
    public List<string> captions;

    public void InteractRadio()
    {
        if (Inventory.main.hasBatteries) DialogueControl.main.AddCaption(captions);
        puzzle.canBeClicked = true;
    }
}
