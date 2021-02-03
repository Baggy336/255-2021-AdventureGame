using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorNeedsKey : MonoBehaviour
{
    // Declare variables to store information
    
    public Transform rotatePiece;
    public List<string> captions;
    public float animLength = .5f;
    private float animTimer = 0;
    private float doorAngle = 0;
    private bool isAnimPlaying = false;
    private bool isClosed = true;

    void Update()
    {
        // Play the animation
        if (isAnimPlaying)
        {
            if (!isClosed) // If the door is not closed, play the animation by deltaTime
                animTimer += Time.deltaTime;
            else // Otherwise, play the animation backwards by deltaTime
                animTimer -= Time.deltaTime;

            float percent = animTimer / animLength;

            // Use the percent value to clamp the animation.
            if (percent < 0 && isClosed)
            {
                percent = 0;
                isAnimPlaying = false;
            }
            if (percent > 1 && !isClosed)
            {
                percent = 1;
                isAnimPlaying = false;
            }
            rotatePiece.localRotation = Quaternion.Euler(0, doorAngle * percent, 0); // Rotate the piece each tick.
        }
    }
    public void PlayerInteract(Vector3 position)
    {
        if (Inventory.main.hasRoomKey == false) DialogueControl.main.AddCaption(captions);
        if (Inventory.main.hasRoomKey)
        {
            // If the animation is playing already, return nothing
            if (isAnimPlaying) return;

            Vector3 disToPlayer = position - transform.position; // Calculate how far the player is from the door
            disToPlayer = disToPlayer.normalized; // Makes the value between 0 and 1

            // Decide which side the player is on
            bool playerBehindDoor = (Vector3.Dot(disToPlayer, transform.forward) > 0f);

            // Toggle door state
            isClosed = !isClosed;

            if (!isClosed) // Only set the door angle if the door isn't closed
            {
                doorAngle = 90;
                if (playerBehindDoor) doorAngle = -90;
            }
            isAnimPlaying = true;

            // Set the playhead to the beginning, or end, depending on where the player is
            if (isClosed) animTimer = animLength;
            else animTimer = 0;
        }
          
    }
   
    
}
