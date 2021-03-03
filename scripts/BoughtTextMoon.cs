using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoughtTextMoon : MonoBehaviour {
    public planetBoughtText planetBoughtText;

    // Use this for initialization
    void Start () {
        planetBoughtText.changeMoonBoughtText();

    }
	
	// Update is called once per frame
	void Update () {
        planetBoughtText.changeMoonBoughtText();


    }
}
