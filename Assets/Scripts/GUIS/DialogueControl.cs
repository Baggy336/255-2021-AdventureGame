using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{
    public List<string> captions;
    public Text text;
    static public DialogueControl main;
    // Start is called before the first frame update
    void Start()
    {
        if (main == null)
        {
            main = this;
            DontDestroyOnLoad(gameObject);
            DisplayCurrentCaption();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            NextCaption();
        }
    }

    private void NextCaption()
    {
        captions.RemoveAt(0);
        DisplayCurrentCaption();

    }

    private void DisplayCurrentCaption()
    {
        if (captions.Count <= 0)
        {
            text.text = "";
        }
        else
        {
            text.text = captions[0] + "\n [Right Click to Continue]";
        }
    }

    public void AddCaption(List<string> c)
    {
        captions.AddRange(c);
        DisplayCurrentCaption();
    }
}
