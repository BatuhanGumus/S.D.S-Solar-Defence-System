using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateCareerText : MonoBehaviour {
    public Text gotHitText;
    public Text hitufoText;
    public Text reflectedText;
    private int gothitvalue;
    private int hitufovalue;
    private int reflectedvalue;
    // Use this for initialization
    void Start () {
        gothitvalue = PlayerPrefs.GetInt("gotHitTimes");
        hitufovalue = PlayerPrefs.GetInt("hitUfoTimes");
        reflectedvalue = PlayerPrefs.GetInt("reflectedTimes");

        gotHitText.text = "Got Hit " + gothitvalue + " Times";
        hitufoText.text = "Hit UFO " + hitufovalue + " Times";
        reflectedText.text = "Reflected " + reflectedvalue + " Times";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
