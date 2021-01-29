using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPickup : MonoBehaviour
{
    // Declare variables to store values
    public Image imgRoomKey;
    public Image imgPuzzlePiece1;
    public Image imgPuzzlePiece2;
    public Image imgPuzzlePiece3;
    public Image imgCarKey;
    public Image imgKeepsake;
    public Image imgElectronicFrame;
    public Image imgPianoTuner;
    public Image imgWardrobeKey; 
    public Image imgBaseball;
    public Image imgDishIngredient;
    public Image imgBatteries;
    public Image crosshair;
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
        imgBatteries.gameObject.SetActive(Inventory.main.hasBatteries);
    }

}
