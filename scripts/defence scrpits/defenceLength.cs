using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defenceLength : MonoBehaviour {
	public GameManager gameManager;


	// Use this for initialization
	void Start () { 
 		changeLength ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeLength (){
        gameManager.getDefenceLength();
        transform.localScale = new Vector3(gameManager.getDefenceScale, transform.localScale.y, transform.localScale.z);

	}
}
