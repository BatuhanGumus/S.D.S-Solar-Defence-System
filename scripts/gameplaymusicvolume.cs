using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplaymusicvolume : MonoBehaviour {
    AudioSource audio;
    // Use this for initialization
    void Start () {
        audio = gameObject.GetComponent<AudioSource>();

        float volumeValue = PlayerPrefs.GetFloat("volume");
        audio.volume = volumeValue;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
