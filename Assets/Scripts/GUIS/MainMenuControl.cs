using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuControl : MonoBehaviour
{
    // Declare event systems as a variable
    EventSystem events;

    void Start()
    {
        // Declare events as a component
        events = GetComponentInChildren<EventSystem>();
    }
    void Update()
    {
        if (events == null) return; // If no events are present
        if (events.currentSelectedGameObject == null) // If no objects are selected
        {
            if (events.firstSelectedGameObject != null) events.SetSelectedGameObject(events.firstSelectedGameObject); // Select the first selected object
        }      
    }
    public void PlayButtonPressed()
    {
        // Scene swap to the first game scene
        SceneManager.LoadScene("OpeningScene");
    }
    public void AboutButtonPressed()
    {
        // Bring up the about page
        SceneManager.LoadScene("AboutPage");
    }
    public void QuitButtonPressed()
    {
        Application.Quit();
    }
}
