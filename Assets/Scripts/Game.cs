using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using TMPro;

public class Game : MonoBehaviour
{
    // Text (Main Menu)
    public TMP_Text GameTitle;
    public TMP_Text PlayButton;
    public TMP_Text SettingButton;
    public TMP_Text AboutButton;
    public TMP_Text QuitButton;
    // Text (Settings)
    public TMP_Text SettingTitle;
    public TMP_Text LanguageText;
    public TMP_Text SaveButton;
    public TMP_Text BackButton;
    // Start is called before the first frame update
    void Start()
    {
        Load();
    }
    void Load()
    {
        string saveString = File.ReadAllText("Assets/Data/Settings.json");
        SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
        if (saveObject.LanguageSet == 0)
        {
            // Titles
            GameTitle.text = "3D Testing";
            SettingTitle.text = "Settings";
            LanguageText.text = "Language";
            // Buttons
            PlayButton.text = "Play";
            SettingButton.text = "Settings";
            AboutButton.text = "About";
            QuitButton.text = "Quit";
            SaveButton.text = "Save";
            BackButton.text = "Back";

        }
        if (saveObject.LanguageSet == 1)
        {
            // Title
            GameTitle.text = "3D 테스트";
            SettingTitle.text = "설정";
            LanguageText.text = "언어";
            // Buttonss
            PlayButton.text = "놀다";
            SettingButton.text = "설정";
            AboutButton.text = "에 대한";
            QuitButton.text = "그만두다";
            SaveButton.text = "구하다";
            BackButton.text = "뒤쪽에";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private class SaveObject
    {
        public int LanguageSet;
    }
}
