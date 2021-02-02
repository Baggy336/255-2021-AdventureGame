using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickupObjectPuzzlePiece1 : MonoBehaviour
{
    public UIControl uiControl;
    public bool canBeClicked;

    public void GrabPiece1()
    {
        if (canBeClicked)
        {
            // Tell the inventory the player has the first puzzle piece
            Inventory.main.hasPuzzlePiece1 = true;
            uiControl.FadeIn();
        }
    }
    private void Update()
    {
        if (Inventory.main.hasPuzzlePiece1 && !uiControl.isCurrentlyFading)
        {

            SceneManager.LoadScene("LivingRoom2");

        }
    }
}
