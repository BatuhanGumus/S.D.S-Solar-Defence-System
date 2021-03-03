using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defenceFakeLength : MonoBehaviour {
    public defenceLength defenceLength;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        defenceLength.changeLength();

    }
}
