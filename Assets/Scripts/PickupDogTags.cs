using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDogTags : MonoBehaviour
{
    public GiveDogTags giveTags;
    public void GrabDogTags()
    {
        Inventory.main.hasDogTags = true;
        giveTags.hasTags = true;
        Destroy(gameObject);
    }
}
