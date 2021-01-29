using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPickup : MonoBehaviour
{
    // Declare variables to store values
    public Transform imgRoomKey;
    public Transform imgPuzzlePiece1;
    public Transform imgPuzzlePiece2;
    public Transform imgPuzzlePiece3;
    public Transform imgCarKey;
    public Transform imgKeepsake;
    public Transform imgElectronicFrame;
    public Transform imgPianoTuner;
    public Transform imgWardrobeKey; 
    public Transform imgBaseball;
    public Transform imgDishIngredient;
    void Update()
    {
        imgRoomKey.gameObject.SetActive(Inventory.main.hasRoomKey);
        imgPuzzlePiece1.gameObject.SetActive(Inventory.main.hasPuzzlePiece1);
        imgPuzzlePiece2.gameObject.SetActive(Inventory.main.hasPuzzlePiece2);
        imgPuzzlePiece3.gameObject.SetActive(Inventory.main.hasPuzzlePiece3);
        imgCarKey.gameObject.SetActive(Inventory.main.hasSpareCarKey);
        imgKeepsake.gameObject.SetActive(Inventory.main.hasKeepsake);
        imgElectronicFrame.gameObject.SetActive(Inventory.main.hasElectronicFrame);
        imgPianoTuner.gameObject.SetActive(Inventory.main.hasPianoTuner);
        imgWardrobeKey.gameObject.SetActive(Inventory.main.hasWardrobeKey);
        imgBaseball.gameObject.SetActive(Inventory.main.hasBaseball);
        imgDishIngredient.gameObject.SetActive(Inventory.main.hasDishIngredient);
    }

}
