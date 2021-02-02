using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Require a Camera component to operate
[RequireComponent(typeof(Camera))]
public class RayCast : MonoBehaviour
{
    // Declare a variable to store the camera
    private Camera cam;

    void Start()
    {
        // Find the camera component once
        cam = GetComponent<Camera>();
    }
    void Update()
    {
        // See if the user clicked each game tick
        if (cam != null && Input.GetButtonDown("Fire1"))
        {
            // Shoot a new ray into the scene from the center of the camera
            Ray ray = new Ray(cam.transform.position, cam.transform.forward);
            // See if the ray hit something in the scene
            RaycastHit hit;

            // Do something if the ray hit
            if (Physics.Raycast(ray, out hit))
            {
                // Open the door if that is what is hit
                DoorOpen door = hit.transform.GetComponentInParent<DoorOpen>();
                if (door != null) door.PlayerInteract(transform.parent.position);

                // Open the cabinet if hit
                CabinetOpen cabinet = hit.transform.GetComponentInParent<CabinetOpen>();
                if (cabinet != null) cabinet.PlayerInteract(transform.parent.position);

                // Pickup the room key if hit
                PickupObjectRoomKey roomKey = hit.transform.GetComponent<PickupObjectRoomKey>();
                if (roomKey != null) roomKey.GrabObject();

                // Pickup the first puzzle piece if hit
                PickupObjectPuzzlePiece1 puzzle1 = hit.transform.GetComponent<PickupObjectPuzzlePiece1>();
                if (puzzle1 != null) puzzle1.GrabPiece1();

                // Pickup the second puzzle piece if hit
                PickupObjectPuzzlePiece2 puzzle2 = hit.transform.GetComponent<PickupObjectPuzzlePiece2>();
                if (puzzle2 != null) puzzle2.GrabPiece2();

                // Pickup the third puzzle piece if hit
                PickupObjectPuzzlePiece3 puzzle3 = hit.transform.GetComponent<PickupObjectPuzzlePiece3>();
                if (puzzle3 != null) puzzle3.GrabPiece3();

                // Pickup the soup if hit
                PickupObjectSoup soup = hit.transform.GetComponent<PickupObjectSoup>();
                if (soup != null) soup.GrabSoup();

                // Pickup the baseball if hit
                PickupObjectBaseball ball = hit.transform.GetComponent<PickupObjectBaseball>();
                if (ball != null) ball.GrabBaseball();

                // Pickup the car key if hit
                PickupObjectCarKey carKey = hit.transform.GetComponent<PickupObjectCarKey>();
                if (carKey != null) carKey.GrabCarKey();

                // Pickup the ingredient if hit
                PickupObjectCookingIngredient ingredient = hit.transform.GetComponent<PickupObjectCookingIngredient>();
                if (ingredient != null) ingredient.GrabIngredient();

                // Pickup the piano tuner if hit
                PickupObjectPianoTuner tuner = hit.transform.GetComponent<PickupObjectPianoTuner>();
                if (tuner != null) tuner.GrabPianoTuner();

                // Pickup the frame if hit
                PickupObjectFrame frame = hit.transform.GetComponent<PickupObjectFrame>();
                if (frame != null) frame.GrabFrame();

                // Pickup the key if hit
                PickupObjectWardrobeKey wKey = hit.transform.GetComponent<PickupObjectWardrobeKey>();
                if (wKey != null) wKey.GrabKey();

                // Pickup the keepsake if hit
                PickupObjectKeepsake keepsake = hit.transform.GetComponent<PickupObjectKeepsake>();
                if (keepsake != null) keepsake.GrabKeepsake();

                // Pickup the batteries if hit
                PickupObjectBatteries batteries = hit.transform.GetComponent<PickupObjectBatteries>();
                if (batteries != null) batteries.GrabBatteries();

                // Pickup the script if hit
                PickupObjectScript script = hit.transform.GetComponent<PickupObjectScript>();
                if (script != null)
                {
                    script.GrabScript();
                    
                }

                // Click the certificate
                PickupObjectCertificate certificate = hit.transform.GetComponent<PickupObjectCertificate>();
                if (certificate != null) certificate.GrabCertificate();

                // Click the dog tags
                PickupDogTags tags = hit.transform.GetComponent<PickupDogTags>();
                if (tags != null) tags.GrabDogTags();

                // Give dog tags
                GiveDogTags give = hit.transform.GetComponent<GiveDogTags>();
                if (give != null) give.GiveTags();

                PickupKeysSecond key2 = hit.transform.GetComponent<PickupKeysSecond>();
                if (key2 != null) key2.GrabSecondCarKey();

                PickupBaseballAgain ball2 = hit.transform.GetComponent<PickupBaseballAgain>();
                if (ball2 != null) ball2.GrabBaseballAgain();

                ClickedOnDad dad = hit.transform.GetComponent<ClickedOnDad>();
                if (dad != null) dad.ThrowBall();

                DoorNeedsKey locked = hit.transform.GetComponentInParent<DoorNeedsKey>();
                if (locked != null) locked.PlayerInteract(transform.parent.position);

                PickupLivingRoomBaseball ball3 = hit.transform.GetComponent<PickupLivingRoomBaseball>();
                if (ball3 != null) ball3.LivingRoomBall();

                InteractWithDrawer drawer = hit.transform.GetComponentInChildren<InteractWithDrawer>();
                if (drawer != null) drawer.PlayerInteract(transform.parent.position);

            }
        }
    }
}
