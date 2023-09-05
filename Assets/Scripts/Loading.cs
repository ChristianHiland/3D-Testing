using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using TMPro;

public class Loading : MonoBehaviour
{
    // Text
    public TMP_Text LoadingText;
    // Start is called before the first frame update
    void Start()
    {
        // Once the player hits Play, it will switch to Scene 2 (The Game Scene)
        SceneManager.LoadScene("Main");

    }
    void Language()
    {
        string saveString = File.ReadAllText("Assets/Data/Settings.json");
        SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
        if (saveObject.LanguageSet == 0)
        {
            // Titles
            LoadingText.text = "Now Loading...";
        }
        if (saveObject.LanguageSet == 1)
        {
            // Titles
            LoadingText.text = "지금 로드 중...";
        }
    }
    private class SaveObject
    {
        public int LanguageSet;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
