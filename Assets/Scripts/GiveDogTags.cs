using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveDogTags : MonoBehaviour
{
    public bool hasTags = false;
    public bool recievedTags = false;
    public PickupObjectCarKey keys;

    public void GiveTags()
    {
        if(hasTags)
        {
            recievedTags = true;
            keys.canBeClicked = true;
        }
        else
        {

        }
        
    }
}
