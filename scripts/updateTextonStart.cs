using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateTextonStart : MonoBehaviour {

		public GameManager gameManager;

	// Use this for initialization
	void Start () {
		gameManager.showDefenceExpanse();
		gameManager.showShieldExpense();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
