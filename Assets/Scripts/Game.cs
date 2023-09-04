using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using TMPro;
using System;

public class Game : MonoBehaviour
{
    // Text (Main Menu)
    public TMP_Text GameTitle;
    public TMP_Text PlayButton;
    public TMP_Text SettingButton;
    public TMP_Text AboutButton;
    public TMP_Text QuitButton;
    // Text (Settings Menu)
    public TMP_Text SettingTitle;
    public TMP_Text LanguageText;
    public TMP_Text SaveButton;
    public TMP_Text BackButton;
    // Text (About Menu)
    public TMP_Text AboutTitle;
    public TMP_Text AboutText2;
    public TMP_Text AboutText3;
    public TMP_Text BackButtonA;
    // Start is called before the first frame update
    void Start()
    {

    }
    void LoadLanguage()
    {
        string saveString = File.ReadAllText("Assets/Data/Settings.json");
        SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
        if (saveObject.LanguageSet == 0)
        {
            // Titles
            GameTitle.text = "3D Testing";
            SettingTitle.text = "Settings";
            LanguageText.text = "Language";
            AboutTitle.text = "About";
            // Buttons
            PlayButton.text = "Play";
            SettingButton.text = "Settings";
            AboutButton.text = "About";
            QuitButton.text = "Quit";
            SaveButton.text = "Save";
            BackButton.text = "Back";
            BackButtonA.text = "Back";
            // Text
            AboutText2.text = "Coder: Lee Lunbin\nDesign: Lee Lunbin\nScripts: Lee Lunbin";
            AboutText3.text = "Version: 0.2 \nState: Dev";
        }
        if (saveObject.LanguageSet == 1)
        {
            // Titles
            GameTitle.text = "3D 테스트";
            SettingTitle.text = "설정";
            LanguageText.text = "언어";
            AboutTitle.text = "에 대한";
            // Buttons
            PlayButton.text = "놀다";
            SettingButton.text = "설정";
            AboutButton.text = "에 대한";
            QuitButton.text = "그만두다";
            SaveButton.text = "구하다";
            BackButton.text = "뒤쪽에";
            BackButtonA.text = "뒤쪽에";
            // Text
            AboutText2.text = "코더: 이룬빈\n설계: 이룬빈\n스크립트: 이룬빈";
            AboutText3.text = "버전: 0.2 \n상태: 개발";
        }
    }

    // Update is called once per frame
    void Update()
    {
        LoadLanguage();
    }
    private class SaveObject
    {
        public int LanguageSet;
    }
}
