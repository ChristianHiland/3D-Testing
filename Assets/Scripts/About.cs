using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class About : MonoBehaviour
{
    // About Text
    public GameObject AboutText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Check if the user pressed the I key, if it was then show the Info screen.
        if (Input.GetKeyDown(KeyCode.I))
        {
            AboutText.SetActive(!AboutText.activeSelf);
        }
    }
}
