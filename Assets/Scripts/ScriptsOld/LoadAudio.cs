using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAudio : MonoBehaviour
{
    public AudioSource music;
    void Start()
    {
        music = GetComponent<AudioSource>();
        music.volume = MainMenu.volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
