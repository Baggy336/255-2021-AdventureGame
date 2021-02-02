using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithDrawer : MonoBehaviour
{
    public bool isDrawerLocked = true;
    public bool isAnimPlaying = false;
    public bool isClosed = true;
    public float animLength = .5f;
    private float animTimer = 0;
    
    public GameObject currentPos;
    public GameObject targetPos;
    
    public Transform slidePiece;

    private void Update()
    {
        if (isAnimPlaying)
        {
            if (!isClosed) // If the door is not closed, play the animation by deltaTime
                animTimer += Time.deltaTime;
            else // Otherwise, play the animation backwards by deltaTime
                animTimer -= Time.deltaTime;

            float percent = animTimer / animLength;

            if (percent < 0)
            {
                percent = 0;
                isAnimPlaying = false;
            }
            if (percent > 1)
            {
                percent = 1;
                isAnimPlaying = false;
            }
            //slidePiece.localPosition = AnimMath.Slide(currentPos.transform.position, targetPos.transform.position, .5f);
            
        }
        
    }
    public void PlayerInteract(Vector3 position)
    {
        if (isAnimPlaying) return;

        

        
        isAnimPlaying = true;
        if (isClosed) animTimer = animLength;
        else animTimer = 0;
    }
    
}
