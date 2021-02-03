using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    private float currentAlpha = 0;
    public float percentPerSecond = .5f;

    // Any script can get, but only this script can set.
    public bool isCurrentlyFading
    {
        private set;
        get;
    }
    private bool isFadeIn = false;

    public Image blackOutSquare;
    public Image crosshair;
    public Image inventory;
    public Image dogTags;
    public Image soupCan;
    public Image lemon;
    public Image baseball;
    public Image doorKey;
    public Text textBox;
    public Text inventoryText;
    public Text dogTagText;
    public Text soupCanText;
    public Text lemonText;
    public Text baseballText;
    public Text doorKeyText;



    void Start()
    {
        inventory.enabled = false;
        inventoryText.enabled = false;
        dogTags.enabled = false;
        dogTagText.enabled = false;
        soupCan.enabled = false;
        soupCanText.enabled = false;
        lemon.enabled = false;
        lemonText.enabled = false;
        baseball.enabled = false;
        baseballText.enabled = false;
        doorKey.enabled = false;
        doorKeyText.enabled = false;
        FadeOut();

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) && !inventory.enabled)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            inventory.enabled = true;
            inventoryText.enabled = true;
            if (Inventory.main.hasDogTags) dogTags.enabled = true;
            if (Inventory.main.hasSoup) soupCan.enabled = true;
            if (Inventory.main.hasDishIngredient) lemon.enabled = true;
            if (Inventory.main.hasBaseball || Inventory.main.hasBaseball2) baseball.enabled = true;
            if (Inventory.main.hasRoomKey) doorKey.enabled = true;

           

        }

        if (Input.GetKeyDown(KeyCode.Escape) && inventory.enabled)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            inventory.enabled = false;
            inventoryText.enabled = false;
            dogTags.enabled = false;
            dogTagText.enabled = false;
            soupCan.enabled = false;
            soupCanText.enabled = false;
            lemon.enabled = false;
            lemonText.enabled = false;
            baseball.enabled = false;
            baseballText.enabled = false;
            doorKey.enabled = false;
            doorKeyText.enabled = false;
        }
        
        if (isCurrentlyFading)
        {
            if (isFadeIn)
            {
                currentAlpha += percentPerSecond * Time.deltaTime;
                if(currentAlpha > 1)
                {
                    isCurrentlyFading = false;
                    currentAlpha = 1;
                }
            }
            else
            {
                currentAlpha -= percentPerSecond * Time.deltaTime;
                if(currentAlpha < 0)
                {
                    isCurrentlyFading = false;
                    currentAlpha = 0;
                }
            }
            
            blackOutSquare.color = new Color(0, 0, 0, currentAlpha);
            crosshair.color = new Color(255, 255, 255, -(currentAlpha - 1));
            //inventorySpaceOne.color = new Color(255, 255, 255, -(currentAlpha - 1));
            //inventorySpaceTwo.color = new Color(255, 255, 255, -(currentAlpha - 1));
            //inventorySpaceThree.color = new Color(255, 255, 255, -(currentAlpha - 1));
            //inventorySpaceFour.color = new Color(255, 255, 255, -(currentAlpha - 1));
            textBox.color = new Color(0.5f, 0.5f, 0.5f, -(currentAlpha - 1));
            //text.color = new Color(1, 1, 1, - (currentAlpha - 1));

        }
    }
    public void FadeIn()
    {
        currentAlpha = 0;
        isCurrentlyFading = true;
        isFadeIn = true;
    }
    public void FadeOut()
    {
        currentAlpha = 1;
        isCurrentlyFading = true;
        isFadeIn = false;
    }
    /*
    public IEnumerator FadeBlackoutSquare(bool fadeToBlack = false, float fadeSpeed = 5)
    {
        hasFinished = false;
        // Get the Object's color component
        //Color objectColor = blackOutSquare.GetComponent<Image>().color;
        float fadeAmount; // How much it will fade per frame

        if (fadeToBlack)
        {
            while (blackOutSquare.GetComponent<Image>().color.a < 1)
            {
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                 Set a color to fade to
                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.color = objectColor;
                yield return null;
            }
        }else  If the screen is already black
        {
            while(blackOutSquare.GetComponent<Image>().color.a > 0)
            {
                fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        }
        hasFinished = true;
    }
    */
   
    
}
