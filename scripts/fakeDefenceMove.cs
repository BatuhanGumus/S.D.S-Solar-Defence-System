using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakeDefenceMove : MonoBehaviour {
    public float speed = 1f;
    public float orig = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.right * speed * Time.deltaTime;

		if(transform.position.x > 4){transform.position = new Vector2 (-4, orig);}
        if (transform.position.x < -4) { transform.position = new Vector2(4, orig); }
    }
}
