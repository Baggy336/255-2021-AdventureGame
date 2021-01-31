using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickupObjectFrame : MonoBehaviour
{
    public UIControl uiControl;
    public bool canBeClicked = false;

    public void GrabFrame()
    {
        if (canBeClicked)
        {
            // Tell the inventory the player has the frame
            Inventory.main.hasElectronicFrame = true;
            uiControl.FadeIn();
        }
        
        
    }
    private void Update()
    {
        if (Inventory.main.hasElectronicFrame && !uiControl.isCurrentlyFading)
        {

            SceneManager.LoadScene("AboutPage");

        }

    }
}
