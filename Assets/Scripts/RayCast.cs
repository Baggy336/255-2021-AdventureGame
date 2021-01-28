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
            }
        }
    }
}
