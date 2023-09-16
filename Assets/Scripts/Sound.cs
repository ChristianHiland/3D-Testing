using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    // Sound Name
    public string Name;
    // The Audio Clip To be Played
    public AudioClip Clip;
    // Volume and Pitch
    [Range(0f,1f)]
    public float Volume;
    [Range(.1f,3f)]
    public float Pitch;
    // Looping
    public bool Loop;
    // Audio Sourse
    [HideInInspector]
    public AudioSource Source;

}
