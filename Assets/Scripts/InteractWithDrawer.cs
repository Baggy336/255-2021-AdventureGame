using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithDrawer : MonoBehaviour
{
    public bool isDrawerLocked = true;
    public bool isAnimPlaying = false;
    public bool isClosed = true;
    public float animLength = 2;
    public bool hasDrawerBeenOpened = false;
    public float timesOpened = 0;
    
    private float animPlayheadTime = 0;
    public float percent = 0;

    public float getCurrentPercent
    {
        get
        {
            return animPlayheadTime / animLength;
        }
    }
    
    public GameObject currentPos;
    public GameObject targetPos;
    public AnimationCurve animationCurve;
    public Transform slidePiece;
    public List<string> captions;


    public void ClickDrawer()
    {
        if (isDrawerLocked)
        {
            isAnimPlaying = false;
            DialogueControl.main.AddCaption(captions);
        }
        else if (!isDrawerLocked)
        {
            isAnimPlaying = true;
            animPlayheadTime = 0;
        }
        
        
    }
    private void Update()
    {
        

        if (Inventory.main.hasWardrobeKey) isDrawerLocked = false;
            if (isAnimPlaying && !isDrawerLocked && !hasDrawerBeenOpened)
            {
                animPlayheadTime += Time.deltaTime;

                percent = getCurrentPercent;

                percent = Mathf.Clamp(percent, 0, 1);

                float p = animationCurve.Evaluate(percent);

                Lerpy(p);

                if (percent > 1) isAnimPlaying = false;
                
                if (percent == 1) hasDrawerBeenOpened = true;

            }
        
        
       
    }
    public void OnValidate()
    {
        Lerpy(percent);
    }
    public void Lerpy(float p)
    {
        transform.position = AnimMath.Lerp(currentPos.transform.position, targetPos.transform.position, p);
    }  
}
