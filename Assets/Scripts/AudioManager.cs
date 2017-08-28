
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour {

    public Sound[] sounds;


    // Use this for initialization
    void Awake () {
		foreach(Sound s in sounds){
           s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;


        }
	}
	
	// Update is called once per frame
	public void Play(string name) {
		
	}
}
