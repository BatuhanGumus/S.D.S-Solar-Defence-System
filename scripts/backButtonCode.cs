using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backButtonCode : MonoBehaviour {

	public string levelName;
    public pause pause;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) { LoadLevel(levelName); }
	}

	public void LoadLevel (string level){
        if (level == "pause") { pause.stopTime(); }
        else if (level == "quit")
        {
            Application.Quit();
        }
        else
        {
            Application.LoadLevel(level);
        }
        
    }
}
