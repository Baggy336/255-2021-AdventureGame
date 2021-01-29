using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverOverButton : MonoBehaviour, IPointerEnterHandler
{
    // List the selectable button component
    Selectable bttn;
    public void OnPointerEnter(PointerEventData eventData)
    {
        bttn.Select();       
    }
    void Start()
    {
        // Declare the button as selectable
        bttn = GetComponent<Selectable>();
    }
}
