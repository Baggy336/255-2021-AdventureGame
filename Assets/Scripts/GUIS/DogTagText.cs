using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogTagText : MonoBehaviour
{

    public Text uiText;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseEnter()
    {
        uiText.enabled = true;
    }

    public void OnMouseExit()
    {
        uiText.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
