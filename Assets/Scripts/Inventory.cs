using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Use the singleton design pattern
    private static Inventory _main;
    public static Inventory main
    {
        get { return _main;  }
        private set { _main = value;  }
    }

    // List items using booleans here
    public bool hasPuzzlePiece1 = false;
    public bool hasPuzzlePiece2 = false;
    public bool hasPuzzlePiece3 = false;
    public bool hasSpareCarKey = false;
    public bool hasDishIngredient = false;
    public bool hasBaseball = false;
    public bool hasWardrobeKey = false;
    public bool hasPianoTuner = false;
    public bool hasRoomKey = false;
    public bool hasElectronicFrame = false;
    public bool hasKeepsake = false;
    public bool hasBatteries = false;

    private void Start()
    {
        if(_main == null)
        {
            // Don't destroy the original inventory
            _main = this;
            DontDestroyOnLoad(gameObject);
        }
        else // Destroy any excess inventory systems
        {
            Destroy(gameObject);
        }      
    }
}
   
