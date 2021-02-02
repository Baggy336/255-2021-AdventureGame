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
    public Image inventorySpaceOne;
    public Image inventorySpaceTwo;
    public Image inventorySpaceThree;
    public Image inventorySpaceFour;
    public Image textBox;
    public Text text;
    public Text text1;


    void Start()
    {
        FadeOut();
        
    }
    void Update()
    {
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
            text.color = new Color(1, 1, 1, - (currentAlpha - 1));

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
