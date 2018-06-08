using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsScript : MonoBehaviour {

    [Header ("Audio")]
    public float MasterVolume;
    public float EffectsVolume;
    public float MusicVolume;

    [Space]
    public AudioMixer audioMixer;


    private void Start()
    {
        audioMixer.GetFloat("Master Volume", out MasterVolume);
        audioMixer.GetFloat("Effects Volume", out EffectsVolume);
        audioMixer.GetFloat("Music Volume", out MusicVolume);
    }




}
