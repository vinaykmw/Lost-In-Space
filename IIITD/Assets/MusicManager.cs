using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {
    static bool AudioBegin = false;
    public AudioSource audio;
    //public GameObject music;
    void Awake()
    {
        audio = GetComponent<AudioSource>();
       // music = GetComponent<GameObject>();
        if (!AudioBegin)
        {
            audio.Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
    void Update()
    {
        if (Application.loadedLevelName == "Upgraded")
        {
            audio.Stop();
            AudioBegin = false;
        }
    }
}
