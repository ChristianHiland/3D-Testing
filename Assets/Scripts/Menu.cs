using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using TMPro;

public class Menu : MonoBehaviour
{
    public TMP_Dropdown LanguageDrop;
    // This is runned by Unity when the button is pressed, using the inbuilt onClick Func.
    public void Play()
    {
        // Once the player hits Play, it will switch to Scene 1 (The Loading Scene)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // This is runned by Unity when the button is pressed, using the inbuilt onClick Func.
    public void Save()
    {
        int LanguageSetNew = LanguageDrop.value;
        SaveObject saveObject = new SaveObject
        {
            LanguageSet = LanguageSetNew,
        };
        string json = JsonUtility.ToJson(saveObject);
        File.WriteAllText("Assets/Data/Settings.json", json);
        Debug.Log("Language Has Been Changed To " + LanguageSetNew);

    }
    // This is runned by Unity when the button is pressed, using the inbuilt onClick Func.
    public void Quit()
    {
        Application.Quit();
    }
    private class SaveObject {
        public int LanguageSet;
    }
}
