using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldColor : MonoBehaviour {

		public GameManager gameManager;

	// Use this for initialization
	void Start () {
		gameManager.getShieldColor();
		changeColor ();
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public void changeColor () {
		if(gameManager.currentShieldColor == "red"){GetComponent<SpriteRenderer>().color = new Color(1f,0.3f, 0.3f, 0.5f);}
		if(gameManager.currentShieldColor == "blue"){GetComponent<SpriteRenderer>().color = new Color(0f, 1f, 1f, 0.5f); }
		if(gameManager.currentShieldColor == "green"){GetComponent<SpriteRenderer>().color = new Color(0f,1f, 0.5f, 0.5f);}
		if(gameManager.currentShieldColor == "pink"){GetComponent<SpriteRenderer>().color = new Color(1f,0f, 1f, 0.5f);}
		if(gameManager.currentShieldColor == "purple"){GetComponent<SpriteRenderer>().color = new Color(0.5f,0f, 1f, 0.5f);}
		if(gameManager.currentShieldColor == "yellow"){GetComponent<SpriteRenderer>().color = new Color(1f,1f, 0f, 0.5f);}
        if (gameManager.currentShieldColor == "white") { GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f); }
        if (gameManager.currentShieldColor == "orange") { GetComponent<SpriteRenderer>().color = new Color(1f, 0.6f, 0f, 0.5f); }
        if (gameManager.currentShieldColor == "navy") { GetComponent<SpriteRenderer>().color = new Color(0f, 0.1f, 0.9f, 0.5f); }
        if (gameManager.currentShieldColor == "brown") { GetComponent<SpriteRenderer>().color = new Color(0.6f, 0.4f, 0f, 0.5f); }
        if (gameManager.currentShieldColor == "dgreen") { GetComponent<SpriteRenderer>().color = new Color(0f, 0.5f, 0.2f, 0.5f); }
        if (gameManager.currentShieldColor == "silver") { GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 0.5f, 0.5f); }

    }

	public void buttonPressed(){
		gameManager.getShieldColor();
		changeColor ();
	}
}
