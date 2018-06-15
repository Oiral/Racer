using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour {

    
    float MasterVolume = 8;
    float EffectsVolume = 8;
    float MusicVolume = 8;

    [Header("Audio")]
    float maxVol = 20;
    float minVol = -80;

    public AnimationCurve volumeCurve;

    [Header("Sliders")]
    public Slider mainVolumeSlider;
    public Slider effectsSlider;
    public Slider musicSlider;

    [Space]
    public AudioMixer audioMixer;


    private void Start()
    {
        audioMixer.GetFloat("Master Volume", out MasterVolume);
        audioMixer.GetFloat("Effects Volume",  out EffectsVolume);
        audioMixer.GetFloat("Music Volume", out MusicVolume);

        mainVolumeSlider.value = MasterVolume;
        effectsSlider.value = EffectsVolume;
        musicSlider.value = MusicVolume;

    }

    public void UpdateMasterVolume()
    {
        MasterVolume += 10;
        if (MasterVolume > maxVol)
        {
            MasterVolume = minVol;
        }

        mainVolumeSlider.value = MasterVolume;

        audioMixer.SetFloat("Master Volume", MasterVolume);
    }

    public void UpdateEffectsVolume()
    {
        EffectsVolume += 10;
        if (EffectsVolume > maxVol)
        {
            EffectsVolume = minVol;
        }

        effectsSlider.value = EffectsVolume;

        audioMixer.SetFloat("Effects Volume", EffectsVolume);
    }

    public void UpdateMusicVolume()
    {
        MusicVolume += 10;
        if (MusicVolume > maxVol)
        {
            MusicVolume = minVol;
        }

        musicSlider.value = MusicVolume;

        audioMixer.SetFloat("Music Volume", MusicVolume);
    }

    public void UpdateMasterVolumeSlider()
    {
        MasterVolume = mainVolumeSlider.value;

        audioMixer.SetFloat("Master Volume", MasterVolume);
    }

    public void UpdateEffectsVolumeSlider()
    {
        EffectsVolume = effectsSlider.value;

        audioMixer.SetFloat("Effects Volume", EffectsVolume);
    }

    public void UpdateMusicVolumeSlider()
    {
        MusicVolume = musicSlider.value;

        audioMixer.SetFloat("Music Volume", MusicVolume);
    }


}
