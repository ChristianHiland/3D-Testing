using UnityEngine.Audio;
using UnityEngine;
using System;


// To Play: FindObjectOfType<AudioManger>().Play("NameOfSound");
// To Stop: FindObjectOfType<AudioManger>().Stop("NameOfSound");
// Make SURE to have the AudioManger in the sence that you'll add audio.


public class AudioManger : MonoBehaviour
{
    public Sound[] Sounds;
    //public static AudioManger instance;
    void Awake()
    {
        // Making sure there's a instance.
        /*
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        */

        foreach (Sound s in Sounds)
        {
            s.Source = gameObject.AddComponent<AudioSource>();
            // All The Vars From Sound
            s.Source.clip = s.Clip;
            s.Source.loop = s.Loop;
            s.Source.volume = s.Volume;
            s.Source.pitch = s.Pitch;

        }
        
    }

    public void Play(string name)
    {
        Sound s = Array.Find(Sounds, sound => sound.Name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound " + name + " was not found!");
        }
        s.Source.Play();
    }
    public void Stop(string name)
    {
        Sound s = Array.Find(Sounds, sound => sound.Name == name);
        s.Source.Stop();
    }


}
