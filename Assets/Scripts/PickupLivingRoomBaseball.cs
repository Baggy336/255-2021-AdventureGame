using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupLivingRoomBaseball : MonoBehaviour
{
    public DisplayText script;
    public UIControl uiControl;
    public PickupObjectFrame frame;
    public bool clickedBall = false;

    public void LivingRoomBall()
    {
        clickedBall = true;
        frame.canBeClicked = true;
        script.ShowBaseball3Text();
        Destroy(gameObject);
    }
}
