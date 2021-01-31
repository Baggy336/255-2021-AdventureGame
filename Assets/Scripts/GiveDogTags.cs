using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveDogTags : MonoBehaviour
{
    public bool hasTags = false;
    public bool recievedTags = false;
    public PickupObjectCarKey keys;
    public PickupDogTags tags;
    public DisplayText bodyScript;
    public DisplayText bodyScript2;

    public void GiveTags()
    {
        if(hasTags)
        {
            bodyScript.ShowTextTagsOnBody();
            recievedTags = true;
            keys.canBeClicked = true;

        }
        else
        {
            tags.hasTalkedToDad = true;
            bodyScript2.ShowTextClickBody();
        }
        
    }
}
