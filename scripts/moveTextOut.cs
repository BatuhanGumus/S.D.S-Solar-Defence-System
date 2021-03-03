using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveTextOut : MonoBehaviour {

    public Text question;
    public Button yes;
    public Button no;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void pressed()
    {
        question.transform.position = new Vector2(0 - 2 * Screen.width , Screen.height / 3 * 2.1f);
        yes.transform.position = new Vector2(0 - 2 * Screen.width , Screen.height / 3 * 1.5f);
        no.transform.position = new Vector2(0 - 2 * Screen.width, Screen.height / 3 * 1.2f);
    }
}
