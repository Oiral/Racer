using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoversAudioScript : MonoBehaviour {

    public AudioSource engineAudio;

    public AudioSource hoverAudio;

    HoverCarScript hoverScript;
    GameObject audioMan;

    private void Start()
    {
        hoverScript = GetComponentInParent<HoverCarScript>();
        //hoverAudio = GetComponent<AudioSource>();

        audioMan = GameObject.FindGameObjectWithTag("AudioManager");

    }

    float engineSmoothDamp = 0;

    private void Update()
    {
        //engineAudio.pitch = (hoverScript.speed / 60) * 1.5f;
        engineAudio.pitch = Mathf.SmoothDamp(engineAudio.pitch, (hoverScript.speed / 60) * 1.5f, ref engineSmoothDamp, 0.3f);
    }
}
