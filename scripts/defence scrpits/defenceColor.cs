using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defenceColor : MonoBehaviour {
	public GameManager gameManager;

	// Use this for initialization
	void Start () {
		gameManager.getDefenceColor();
		changeColor ();
	}
	
	// Update is called once per frame
	void Update () {
		gameManager.getDefenceColor();
		changeColor ();
	}
	
	public void changeColor () {
		if(gameManager.currentDefenceColor == "red"){GetComponent<SpriteRenderer>().color = new Color(1f,0.3f, 0.3f);}
		if(gameManager.currentDefenceColor == "blue"){GetComponent<SpriteRenderer>().color = new Color(0f,1f, 1f);}
		if(gameManager.currentDefenceColor == "green"){GetComponent<SpriteRenderer>().color = new Color(0f,1f, 0.5f);}
		if(gameManager.currentDefenceColor == "pink"){GetComponent<SpriteRenderer>().color = new Color(1f,0f, 1f);}
		if(gameManager.currentDefenceColor == "purple"){GetComponent<SpriteRenderer>().color = new Color(0.5f,0f, 1f);}
		if(gameManager.currentDefenceColor == "yellow"){GetComponent<SpriteRenderer>().color = new Color(1f,1f, 0f);}
        if (gameManager.currentDefenceColor == "white") { GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f); }
        if (gameManager.currentDefenceColor == "orange") { GetComponent<SpriteRenderer>().color = new Color(1f, 0.6f, 0f); }
        if (gameManager.currentDefenceColor == "navy") { GetComponent<SpriteRenderer>().color = new Color(0f, 0.1f, 0.9f); }
        if (gameManager.currentDefenceColor == "brown") { GetComponent<SpriteRenderer>().color = new Color(0.6f, 0.4f, 0f); }
        if (gameManager.currentDefenceColor == "dgreen") { GetComponent<SpriteRenderer>().color = new Color(0f, 0.5f, 0.2f); }
        if (gameManager.currentDefenceColor == "silver") { GetComponent<SpriteRenderer>().color = new Color(0.5f, 0.5f, 0.5f); }
    }
}
