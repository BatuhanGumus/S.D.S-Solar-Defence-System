using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sheildControl : MonoBehaviour {
	public GameManager gameManager;
	public Text shieldLifeText;
	private float time=0;
	public float fade;

	

	// Use this for initialization
	void Start () {

		gameManager.getShieldDure();
		gameManager.getShieldRegenTime();
		gameManager.shieldLife = gameManager.shieldFullLife; 
		shieldLifeText.text = "+%" + gameManager.shieldLife;

		if (gameManager.shieldFullLife == 0){
			shieldLifeText.text = "";
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameManager.gameEndLose == false){
			time += Time.deltaTime;
			if (gameManager.shieldLife < gameManager.shieldFullLife){
				if (time > gameManager.shieldRegenTime){
					gameManager.shieldLife ++;
					shieldLifeText.text = "+%" + gameManager.shieldLife;
					time = 0;
				}
			}
		}
		if (gameManager.shieldFullLife > 0){fade = gameManager.shieldLife * 100 / gameManager.shieldFullLife;}
		else if (gameManager.shieldFullLife > 0){fade = 0;}
		
	//	GetComponent<SpriteRenderer>().color = new Color(Color.R,0.6f, 0.75f, 0.75f - (0.75f - fade / 150));

		Color tmp = gameObject.GetComponent<SpriteRenderer>().color;
 		tmp.a = 0.33f - (0.33f - fade / 300);
 		gameObject.GetComponent<SpriteRenderer>().color = tmp;
	}
}
