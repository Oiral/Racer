using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSetScript : MonoBehaviour {

    public AudioClip clip;

    private void Start()
    {
        if (clip != null && GameObject.FindGameObjectWithTag("Music") != null)
        {
            AudioSource source = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
            source.clip = clip;
            source.Play();
            Destroy(gameObject);
        }
    }
}
