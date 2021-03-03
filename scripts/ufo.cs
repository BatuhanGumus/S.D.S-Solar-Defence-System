using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo : MonoBehaviour {

	[SerializeField] private Vector2 botpos;
	[SerializeField] private Vector2 toppos;
	[SerializeField] private float updownspeed;	
	[SerializeField] private float waitsec;	

	// Use this for initialization
	void Start () {
		StartCoroutine (Move (botpos));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Move (Vector3 target){
		
		while (Mathf.Abs((target - transform.localPosition).y) > 0.20f) {

			Vector3 direction = target.y == toppos.y ? Vector2.up : Vector2.down;
			transform.localPosition -= direction * updownspeed * Time.deltaTime;

			yield return null;
		}

		yield return new WaitForSeconds (waitsec);

		Vector3 newtarget = target.y == toppos.y ? botpos : toppos;
		
		StartCoroutine (Move (newtarget));
	}
	

}
