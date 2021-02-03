using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveDogTags : MonoBehaviour
{
    public bool hasTags = false;
    public bool recievedTags = false;
    public PickupObjectCarKey keys;
    public PickupDogTags tags;
    
    public List<string> captions;
    public List<string> captions2;

    public void GiveTags()
    {
        if(hasTags)
        {
            DialogueControl.main.AddCaption(captions);
            recievedTags = true;
            keys.canBeClicked = true;
            Inventory.main.hasDogTags = false;

        }
        else
        {
            tags.hasTalkedToDad = true;
            DialogueControl.main.AddCaption(captions2);
        }
        
    }
}
