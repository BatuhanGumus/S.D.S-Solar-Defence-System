using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class links : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void openLink (string link)
    {
        Application.OpenURL(link);
    }
}
