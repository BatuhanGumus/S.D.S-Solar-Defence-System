using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeShieldLifoColor : MonoBehaviour {

		public GameManager gameManager;
		public Text shieldText;

	// Use this for initialization
	void Start () {
		gameManager.getShieldColor();
		changeColor ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void changeColor () {
		if(gameManager.currentShieldColor == "red"){shieldText.color  = new Color(1f,0.3f, 0.3f, 0.5f);}
		if(gameManager.currentShieldColor == "blue"){shieldText.color  = new Color(0f, 1f, 1f, 0.5f);}
		if(gameManager.currentShieldColor == "green"){shieldText.color  = new Color(0f,1f, 0.5f, 0.5f);}
		if(gameManager.currentShieldColor == "pink"){shieldText.color  = new Color(1f,0f, 1f, 0.5f);}
		if(gameManager.currentShieldColor == "purple"){shieldText.color  = new Color(0.5f,0f, 1f, 0.5f);}
		if(gameManager.currentShieldColor == "yellow"){shieldText.color  = new Color(1f,1f, 0f, 0.5f);}
        if (gameManager.currentShieldColor == "white") { shieldText.color = new Color(1f, 1f, 1f, 0.5f); }
        if (gameManager.currentShieldColor == "orange") { shieldText.color = new Color(1f, 0.6f, 0f, 0.5f); }
        if (gameManager.currentShieldColor == "navy") { shieldText.color = new Color(0f, 0.1f, 0.9f, 0.5f); }
        if (gameManager.currentShieldColor == "brown") { shieldText.color = new Color(0.6f, 0.4f, 0f, 0.5f); }
        if (gameManager.currentShieldColor == "dgreen") { shieldText.color = new Color(0f, 0.5f, 0.2f, 0.5f); }
        if (gameManager.currentShieldColor == "silver") { shieldText.color = new Color(0.5f, 0.5f, 0.5f, 0.5f); }

    }

}

