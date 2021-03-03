using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invokeStart : MonoBehaviour {
    

    // Use this for initialization
    void Start () {
        Invoke("loadlevel", 3f);
	}

    public void loadlevel()
    {
        Application.LoadLevel("start menu");
    }
	
}
