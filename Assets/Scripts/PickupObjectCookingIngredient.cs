using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectCookingIngredient : MonoBehaviour
{
    public void GrabIngredient()
    {
        // Tell the inventory the player has the cooking ingredient
        Inventory.main.hasDishIngredient = true;
        Destroy(gameObject);
    }
}
