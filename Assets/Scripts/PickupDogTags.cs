using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDogTags : MonoBehaviour
{
    public GiveDogTags giveTags;
    public bool clickedTags;
    public DisplayText tagScript;
    public bool hasTalkedToDad;
    public void GrabDogTags()
    {
        if (hasTalkedToDad)
        {
            clickedTags = true;
            tagScript.ShowTextGrabTags();
            Inventory.main.hasDogTags = true;
            giveTags.hasTags = true;
            Destroy(gameObject);
        }
        else return;
        
    }
}
