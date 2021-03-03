using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class shieldUlt : MonoBehaviour {
    private bool skipFrame = false;
    public  GameManager gameManager;
   public Text shieldLifeText;
    public bool available = false;
    public bool charge = true;
    public float timer = 40;
    public Button button;
    public Text rechargeText;
    public ultPause ultPause;
    public pause pause;
    public Button ultShieldRegen;
    public GameObject defence;
    public defenceMovement defenceMovement;
    public upgradeAbility upgradeAbility;

    AudioSource audio;

    public AudioClip ready;
    public AudioClip pressed;

    // Use this for initialization
    void Start () {
        audio = gameObject.GetComponent<AudioSource>();
        upgradeAbility.prefToBool();
        if (upgradeAbility.shieldUltBought == true)
        {
            ultShieldRegen.transform.position = new Vector2(0, Screen.height / 3 * 0.9f);
        }

    }
	
	// Update is called once per frame
	void Update () {
        if (upgradeAbility.shieldUltBought == true) {
            if (gameManager.gameStart == true)
            {
                if (charge == true)
                {
                    if (pause.timeStopped == false && gameManager.gameEndLose == false)
                    {
                        //Add only when we don't need to skip frame
                        if (!skipFrame)
                        {
                            timer -= Time.unscaledDeltaTime;

                        }

                        //We need to skip frame. Don't use Time.unscaledDeltaTime this frame
                        else
                        {
                            skipFrame = false;
                            Debug.LogWarning("Filtered accumulated Time when Paused: " + Time.unscaledDeltaTime);
                        }
                       // timer -= Time.unscaledDeltaTime;
                    }

                    button.image.color = new Color(1f, 1f - ((timer * 100 / 40) / 100), 1f - ((timer * 100 / 40) / 100));
                    int timeToInt = (int)timer;
                    ;
                    if (timer <= 0)
                    {
                        ultShieldRegen.transform.position = new Vector2(Screen.width / 5 * 0.6f, Screen.height / 3 * 0.9f);
                        audio.volume = 0.05f;
                        audio.clip = ready;
                        audio.Play();

                        charge = false;
                        available = true;
                        GetComponent<Image>().color = new Color(0f, 1f, 1f);
                    }
                }
            }
        }
	}

    public void Ult()
    {
        
            if (available == true && gameManager.gameEndLose == false)
            {
            audio.volume = 0.50f;
            audio.clip = pressed;
            audio.Play();
            ultShieldRegen.transform.position = new Vector2(0, Screen.height / 3 * 0.9f);
          
            gameManager.shieldLife = gameManager.shieldFullLife;
                shieldLifeText.text = "+%" + gameManager.shieldLife;
                available = false;
                charge = true;
                timer = 40;
                GetComponent<Image>().color = new Color(1f, 0.3f, 0.3f);

            }
        

    }

    void OnApplicationFocus(bool hasFocus)
    {
        //Enable skipFrame when focoused in app
        if (hasFocus)
        {
            //Debug.Log("Has focus");
            skipFrame = true;
        }
    }

    void OnApplicationPause(bool pauseStatus)
    {
        //Enable skipFrame when coming back from exiting app
        if (!pauseStatus)
        {
            //Debug.Log("UnPaused");
            skipFrame = true;
        }
    }
}
