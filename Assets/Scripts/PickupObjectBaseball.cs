using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickupObjectBaseball : MonoBehaviour
{
    public bool canGrabBall = false;
    public bool clickedBaseball = false;
    public DisplayText script;
    public UIControl uiControl;
    public PickupKeysSecond key2;
    public void GrabBaseball()
    {
        if (key2.hasCarKey)
        {
            clickedBaseball = true;
            // Tell the inventory the player has the baseball
            Inventory.main.hasBaseball = true;
            uiControl.FadeIn();
        }
        
            
        
        
    }
    private void Update()
    {
        if (clickedBaseball && !uiControl.isCurrentlyFading)
        {

            SceneManager.LoadScene("House2");

        }

    }
}
