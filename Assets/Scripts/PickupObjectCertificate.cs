using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PickupObjectCertificate : MonoBehaviour
{
    private bool clickedCertificate = false;

    // Reference to the UIControl
    public UIControl uiControl;
    

    public void Start()
    {
        
    }

    public void GrabCertificate()
    {
        clickedCertificate = true;
        // Fade to black
        uiControl.FadeIn();
        
        // Switch scene            
    }
    private void Update()
    {
        if (clickedCertificate && !uiControl.isCurrentlyFading)
        {

            SceneManager.LoadScene("Area1");
            
        }

    }

}
