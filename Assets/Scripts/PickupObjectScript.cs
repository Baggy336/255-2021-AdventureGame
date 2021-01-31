using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickupObjectScript : MonoBehaviour
{
    public int timesPickedUp = 0;
    public GameObject currentPos;
    public GameObject targetPos;
    public float animLength = 2;
    private float animPlayheadTime = 0;
    public float percent = 0;

    public bool clickedScript = false;
    private bool isAnimPlaying = false;

    public UIControl uiControl;
    public DisplayText showScript;
    public AnimationCurve animationCurve;

    public float getCurrentPercent
    {
        get
        {
            return animPlayheadTime / animLength;
        }
    }
    public void GrabScript()
    {
        // Add to timesPickedUp        
               
        clickedScript = true;
        showScript.ShowText();
        isAnimPlaying = true;
        animPlayheadTime = 0;
        
       
               
    }
    
    void Update()
    {
      // Play the first dialouge
      // Make the script move
      if (isAnimPlaying)
      {
            animPlayheadTime += Time.deltaTime;

            percent = getCurrentPercent;

            percent = Mathf.Clamp(percent, 0, 1);

            float p = animationCurve.Evaluate(percent);

            Lerpy(p);

            if (percent > 1) isAnimPlaying = false;
      }
    }
    private void OnValidate()
    {
        Lerpy(percent);
    }
    public void Lerpy(float p)
    {
        transform.position = AnimMath.Lerp(currentPos.transform.position, targetPos.transform.position, p);
    }
    
}
