using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleProjEffect : MonoBehaviour {
    public bool active = false;
    public GameManager gameManager;
    public float stayOnTimer = 0;
    public GameObject defence;
    public pause pause;

    // Use this for initialization
    void Start () {
        gameManager.getDefenceLength();
    }
	
	// Update is called once per frame
	void Update () {

        if (active == true)
        {
            if (pause.timeStopped == false)
            {
                stayOnTimer += Time.unscaledDeltaTime;
            }

            defence.transform.localScale = new Vector3(gameManager.getDefenceScale /2 + ((stayOnTimer * 100 / 10) / 100), transform.localScale.y, transform.localScale.z);
            if (stayOnTimer >= 10)
            {

                active = false;
                stayOnTimer = 0;

            }
        }
    }
}
