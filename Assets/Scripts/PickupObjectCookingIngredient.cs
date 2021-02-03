using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectCookingIngredient : MonoBehaviour
{
    public bool grabLemon = false;
    public List<string> captions;
    public PickupKeysSecond key2;
    
    public void GrabIngredient()
    {
        // Tell the inventory the player has the cooking ingredient
        grabLemon = true;
        key2.canBeClicked = true;
        DialogueControl.main.AddCaption(captions);
        Inventory.main.hasDishIngredient = true;
        Destroy(gameObject);
    }
}
