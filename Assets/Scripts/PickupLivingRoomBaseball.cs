using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupLivingRoomBaseball : MonoBehaviour
{
    public List<string> captions;
    public UIControl uiControl;
    public PickupObjectFrame frame;
    public bool clickedBall = false;

    public void LivingRoomBall()
    {
        clickedBall = true;
        frame.canBeClicked = true;
        DialogueControl.main.AddCaption(captions);
        Destroy(gameObject);
    }
}
