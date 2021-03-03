using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class setVolumrSlider : MonoBehaviour {
    public Slider slider;
	// Use this for initialization
	void Start () {
        slider = GetComponent<Slider>();
        float volumevalue = PlayerPrefs.GetFloat("volume");
        slider.value = volumevalue;

    }

    // Update is called once per frame
    void Update () {
		
	}
}
