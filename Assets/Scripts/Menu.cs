using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // The Exit Button
    public Button Quit;
    public GameObject QuitButton;
 
    // Start is called before the first frame update
    void Start()
    {
        // Start the game without the Menu elements
        Quit.interactable = false;
        // Keeps track on if the user pressed the Quit Button, and if they did then run OnClickHandler.
        Quit.onClick.AddListener(QuitHandler);
    }
    // Runs when the button Quit has been pressed.
    void QuitHandler()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#endif
    }

    // Update is called once per frame.
    void Update()
    {
        // Check if the user pressed the Q was pressed, and if it was then show the menu.
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Toggle the visibility of the UI element
            QuitButton.SetActive(!QuitButton.activeSelf);
            Quit.interactable = !Quit.interactable;
        }
    }
}
