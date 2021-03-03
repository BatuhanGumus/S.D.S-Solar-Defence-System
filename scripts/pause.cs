using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour {
    public GameManager gameManager;
    public bool timeStopped = false;
    public bool trigger = false;
    public float time = 3;
    public Text returnText;
    public ultPause ultPause;
    public bool skip = false;

    AudioSource audio;
    
    // Use this for initialization
    void Start () {
        audio = gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (trigger == true)
        {
            if (gameManager.gameEndLose == false)
            {if (ultPause.timeStopped == false)
                {
                    if (timeStopped == false)
                    {
                        Time.timeScale = 0;
                        trigger = false;
                        timeStopped = true;
                        returnText.fontSize = 70;
                        returnText.text = "Resume";
                        GameObject.Find("restartText").transform.position = new Vector2(Screen.width / 2, Screen.height / 3 * 1.5f);
                        GameObject.Find("returnText").transform.position = new Vector2(Screen.width / 2, Screen.height / 3 * 1.2f);
                        GameObject.Find("mainMenuText").transform.position = new Vector2(Screen.width / 2, Screen.height / 3 * 0.9f);
                    }
                    else if (timeStopped == true)
                    {
                        GameObject.Find("mainMenuText").transform.position = new Vector2(0 - Screen.width, Screen.height / 3f * 1.9f);
                        GameObject.Find("restartText").transform.position = new Vector2(0 - Screen.width, Screen.height / 3f * 1.9f);
                        time -= Time.unscaledDeltaTime;
                        returnText.fontSize = 130;
                        returnText.text = "" + ((int)time + 1);
                        skip = true;
                        if (time <= 0)
                        {
                            Time.timeScale = 1;
                            trigger = false;
                            timeStopped = false;
                            ultPause.trigger = false;
                            skip = false;

                            GameObject.Find("returnText").transform.position = new Vector2(0 - Screen.width, Screen.height / 3f * 1.9f);

                            time = 3;
                        }
                    }
                }
            }
        }
	}


    public void stopTime()
    {
        if (gameManager.gameEndLose == false)
        {
            trigger = true;
            audio.Play();

            if (skip == true)
            {
                time = 0;
            }
        }
    }
}
