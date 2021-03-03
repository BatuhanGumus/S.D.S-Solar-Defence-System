using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ultPause : MonoBehaviour {
    public GameManager gameManager;
    public bool timeStopped = false;
    public bool trigger = false;
    public float time = 3;
    public Text returnText;
    public pause pause;
    public Button ultSlowDownTime;
    public Button ultShieldRegen;
    public Button ultLongerStick;
    public GameObject defence;
    public bool countDone = false;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (trigger == true)
        {
            if (gameManager.gameEndLose == false)
            {if (pause.timeStopped == false)
                {
                    if (timeStopped == false)
                    {
                        countDone = false;
                        Time.timeScale = 0;
                        trigger = false;
                        timeStopped = true;
                        returnText.fontSize = 70;
                        returnText.text = "Choose\nAbility";
                        defence.transform.position = new Vector2(0, -3.2f);
                        returnText.transform.position = new Vector2(Screen.width / 2, Screen.height / 3 * 1.2f);
                        ultSlowDownTime.transform.position = new Vector2(Screen.width / 5 * 4.2f, Screen.height / 3 * 1.5f);
                        ultShieldRegen.transform.position = new Vector2(Screen.width / 5 * 4.2f, Screen.height / 3 * 0.9f);
                        ultLongerStick.transform.position = new Vector2(Screen.width / 5 * 4.2f, Screen.height / 3 * 1.2f);

                    }
                    else if (timeStopped == true)
                    {
                        ultSlowDownTime.transform.position = new Vector2(Screen.width, Screen.height / 3 * 1.5f);
                        ultShieldRegen.transform.position = new Vector2(Screen.width, Screen.height / 3 * 0.9f);
                        ultLongerStick.transform.position = new Vector2(Screen.width, Screen.height / 3 * 1.2f);

                        time -= Time.unscaledDeltaTime * 1.7f;
                        returnText.fontSize = 160;
                        returnText.text = "" + ((int)time + 1);

                        if (time <= 0)
                        {
                            Time.timeScale = 1;
                            trigger = false;
                            timeStopped = false;
                            pause.trigger = false;
                            countDone = true;

                            returnText.transform.position = new Vector2(0 - Screen.width, Screen.height / 3f * 1.9f);

                            time = 3;
                        }
                    }
                }
            }
        }
    }


    public void stopTime()
    {
        trigger = true;
    }
}
