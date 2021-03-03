using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class setHightSlider : MonoBehaviour {
    public Slider slider;
    // Use this for initialization
    void Start () {
        slider = GetComponent<Slider>();
        float hightValue = PlayerPrefs.GetFloat("defenceHight");
        slider.value = hightValue;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
