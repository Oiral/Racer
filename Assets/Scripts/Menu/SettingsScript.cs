using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsScript : MonoBehaviour {

    
    float MasterVolume = 8;
    float EffectsVolume = 8;
    float MusicVolume = 8;

    [Header("Audio")]
    float maxVol = 20;
    float minVol = -80;

    public AnimationCurve volumeCurve;

    [Space]
    public AudioMixer audioMixer;


    private void Start()
    {
        audioMixer.GetFloat("Master Volume", out MasterVolume);
        audioMixer.GetFloat("Effects Volume",  out EffectsVolume);
        audioMixer.GetFloat("Music Volume", out MusicVolume);
    }

    public void UpdateMasterVolume()
    {
        MasterVolume += 10;
        if (MasterVolume > maxVol)
        {
            MasterVolume = minVol;
        }

        audioMixer.SetFloat("Master Volume", MasterVolume);
    }

    public void UpdateEffectsVolume()
    {
        EffectsVolume += 10;
        if (EffectsVolume > maxVol)
        {
            EffectsVolume = minVol;
        }

        audioMixer.SetFloat("Effects Volume", EffectsVolume);
    }

    public void UpdateMusicVolume()
    {
        MusicVolume += 10;
        if (MusicVolume > maxVol)
        {
            MusicVolume = minVol;
        }

        audioMixer.SetFloat("Music Volume", MusicVolume);
    }



}
