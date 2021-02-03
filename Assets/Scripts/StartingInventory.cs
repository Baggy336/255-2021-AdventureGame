using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingInventory : MonoBehaviour
{
       
        public bool hasDishIngredient = false;
        public bool hasBaseball = false;
        public bool hasRoomKey = false;
        public bool hasElectronicFrame = false;
        public bool hasDogTags = false;
        public bool hasSecondKey = false;
        public bool hasSoup = false;
        public bool hasBaseball2 = false;
    
    void Start()
    {
        if (hasDogTags) Inventory.main.hasDishIngredient = true;
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
