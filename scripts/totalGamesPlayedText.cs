using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalGamesPlayedText : MonoBehaviour {
    public Text TotalGamesPlayedText;
	// Use this for initialization
	void Start () {
        int Played = PlayerPrefs.GetInt("roundsplayed");
        TotalGamesPlayedText.text = "Defence Attempts: " + Played;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
