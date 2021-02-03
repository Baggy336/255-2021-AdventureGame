using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogTagText : MonoBehaviour
{

    public Text itemText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseOver()
    {
        itemText.enabled = true;
    }

    public void OnMouseExit()
    {
        itemText.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
