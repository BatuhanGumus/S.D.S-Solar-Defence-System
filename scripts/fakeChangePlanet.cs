using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakeChangePlanet : MonoBehaviour {
    public planetState planetState;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        planetState.fakePlanet();
	}
}
