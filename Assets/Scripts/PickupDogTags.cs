using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDogTags : MonoBehaviour
{
    public GiveDogTags giveTags;
    public bool clickedTags;
    public List<string> captions;
    public bool hasTalkedToDad;

    public void GrabDogTags()
    {
        if (hasTalkedToDad)
        {
            clickedTags = true;
            DialogueControl.main.AddCaption(captions);
            Inventory.main.hasDogTags = true;
            giveTags.hasTags = true;
            Destroy(gameObject);
        }
        else return;
        
    }
}
