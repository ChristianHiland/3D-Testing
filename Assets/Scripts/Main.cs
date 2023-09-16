using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

/// <summary>
/// This script is used for the Testing Game Map.
/// </summary>

public class GameMain : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // Playing the Game Menu Music.
        FindObjectOfType<AudioManger>().Play("GameTheme");

    }

    // Update is called once per frame
    void Update()
    {
        // Checking if the user has pressed the M key, if so, show the Main Menu.
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Menu");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
