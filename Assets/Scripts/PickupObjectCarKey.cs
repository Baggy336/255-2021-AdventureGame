using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickupObjectCarKey : MonoBehaviour
{
    public DisplayText script;
    public UIControl uiControl;
    public bool hasCarKey = false;
    public bool canBeClicked = false;
    public void GrabCarKey()
    {
        if (canBeClicked)
        {
            // Tell the inventory the player has the car key
            Inventory.main.hasSpareCarKey = true;
            hasCarKey = true;
            uiControl.FadeIn();
        }
             
    }
    private void Update()
    {
        if (hasCarKey && !uiControl.isCurrentlyFading)
        {

            SceneManager.LoadScene("House1");

        }

    }
}
