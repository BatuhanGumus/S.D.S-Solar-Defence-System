using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class changeVolume : MonoBehaviour {
  
    // Use this for initialization
    void Start () {
       
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changevolume(float volume)
    {
        PlayerPrefs.SetFloat("volume", volume);
    }
}
