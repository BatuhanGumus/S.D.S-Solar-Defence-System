using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class GameManager : MonoBehaviour {
    private bool skipFrame = false;

    public projectile Projectile;
	public int life = 100;
	public Text lifeText;
	public Text TimeLeftText;
	public int damageMade;
	public Transform prefab;
	public int maxproj;
	public Text startText;
	public Text EndText;
	public Text currencyText;
	public Text recordTimeText;
	public Text timePlayedText;
	public bool gameStart = false;
	public bool earthDead = false;
	public bool gameEndLose = false;
	public bool gameEndWin = false;
    public float time = 0;
	private int currency;
	private int recordTime;
	private bool secondProj = false;
	private bool thirdProj = false;
	private bool fourthProj = false;
    private bool fifthProj = false;
    public int dropped = 0;
	public Text droppedText;
	public Text defenceExtendExpenseText;
	private bool currencyCheck = false;
	public bool timeStopped = false;
	private bool recordTimeCheck = false;
	public string currentDefenceColor;
	public string currentShieldColor;
	public string currentPlanet;
	public float getDefenceScale;
	public int defenceExtendExpense = 300;
	public Text defenceLengthText;
	public int defenceLenghtToText;
	private bool redBoughtState;
	private int damage;
	public buyDefenceColor buyDefenceColor;
	public buyShieldColor buyShieldColor;
	public buyPlanet buyPlanet;
	public int finalDamage;
	public Text shieldLifeText;
	public int shieldRegenTime = 6;
	public int shieldFullLife = 0;
	public int shieldLife;
	public Text shieldLifeExpenseText;	
	public Text shieldRegenExpenseText;
	public Text shieldLifeStateText;	
	public Text shieldRegenStateText;
    private int addExp = 0;
    public Text expText;
    public Text endGameXpText;
    public Text newUSB;
    public pause pause;
    public ultPause ultPause;
    public upgradeAbility upgradeAbility;
    public Text recordText;
    public float projsec;
    public int timePlayed;
    public Text adboostText;
    public buybuttonFX buybuttonFX;
    public animcheckgameplay animcheckgameplay;

    // Use this for initialization
    void Start () {
        Advertisement.Initialize("1560626", false);


        
        damageMade = Random.Range(4, 15);

      // PlayerPrefs.SetInt("currency", 6274);
       //PlayerPrefs.SetInt("USBamount", 3);
        //PlayerPrefs.SetInt("exp", 2970);

        GameObject startTemp = GameObject.Find("startText");
        if (startTemp != null)
        {
            startTemp.transform.position = new Vector2(Screen.width / 2f, Screen.height / 3f * 1.9f);
        }
        GameObject pressTemp = GameObject.Find("pressScreenText");
        if (pressTemp != null)
        {
            pressTemp.transform.position = new Vector2(Screen.width / 2f, Screen.height / 3f * 2.1f);
        }


        int checkad = PlayerPrefs.GetInt("adUse");
        if (checkad > 0)
        {
            adboostText.text = "Ad Boost Active!";
            adboostText.transform.position = new Vector2(Screen.width / 2f, Screen.height / 3f * 2.4f);
        }

        if (TimeLeftText != null)
        {
            int TimeText = (int)time;
            TimeLeftText.text = TimeText.ToString() + "s";
        }
        
	}
	
	// Update is called once per frame
	void Update () {

        if (lifeText != null)
        {
            if (life <= 0)
            {

                lifeText.text = "%0";
                gameEndLose = true;
            }

            float lifetofloat = life;
            lifeText.color = new Color(1f, lifetofloat / 100, lifetofloat / 100, 0.5f);
        }
		

		if (Input.GetMouseButtonDown(0)){
			if(gameStart == false){
			
			}
			gameStart = true;
		
		}

		if (gameStart == true){
		
			GameObject.Find("startText").transform.position = new Vector2 (0 - Screen.width, Screen.height / 3f * 1.9f);
			GameObject.Find("pressScreenText").transform.position = new Vector2 (0 - Screen.width, Screen.height / 3f * 2f);
            animcheckgameplay.gameBegin = true;

            if (gameEndLose == false)
            {
                adboostText.transform.position = new Vector2(0 - Screen.width, Screen.height / 3f * 1.9f);
            }
            


            if (gameEndLose == false && gameEndWin == false) {

                if (pause.timeStopped == false && ultPause.timeStopped == false)
                {
                    //Add only when we don't need to skip frame
                    if (!skipFrame)
                    {
                        time += Time.unscaledDeltaTime;
                        projsec += Time.unscaledDeltaTime;
                        
                    }

                    //We need to skip frame. Don't use Time.unscaledDeltaTime this frame
                    else
                    {
                        skipFrame = false;
                        Debug.LogWarning("Filtered accumulated Time when Paused: " + Time.unscaledDeltaTime);
                    }


                   // time += Time.unscaledDeltaTime;
                   // projsec += Time.unscaledDeltaTime;
                }
                
            int TimeText = (int) time;
                if (TimeText < 60)
                {
                    TimeLeftText.text = TimeText.ToString() + "s";
                }else if (TimeText >= 60)
                {
                    int min = TimeText / 60;
                    TimeLeftText.text = min + "m " + (TimeText - 60 * min) + "s";
                }
			
			}

			if ((int) time >= 5){
				if (secondProj == false){
				Instantiate(prefab, new Vector3(0, 4f, 0), Quaternion.identity);
				Projectile.minSpeed = -2;
				Projectile.maxSpeed = -4;
				secondProj = true;
				}
			}
			if ((int) time >= 10){
				if (thirdProj == false){
				Instantiate(prefab, new Vector3(0, 4f, 0), Quaternion.identity);
				Projectile.minSpeed = -3;
				Projectile.maxSpeed = -5;
				thirdProj = true;
				}
			}
			if ((int) time >= 15){
				if (fourthProj == false){
				Instantiate(prefab, new Vector3(0, 4f, 0), Quaternion.identity);
				Projectile.maxSpeed = -6;
				fourthProj = true;
				}
			}
			if ((int) time >= 30){
				if (fifthProj == false){
				Instantiate(prefab, new Vector3(0, 4f, 0), Quaternion.identity);
                    projsec = 0;
				fifthProj = true;  
				}
            
                if (projsec > 45)
                {
                    Instantiate(prefab, new Vector3(0, 4f, 0), Quaternion.identity);
                    projsec = 0;
                }
            }
			


        }

		if (gameEndLose == true){
            int checkad = PlayerPrefs.GetInt("adUse");

            GameObject.Find("GameOver").transform.position = new Vector2 (Screen.width / 2, Screen.height / 3 * 2.1f);
			GameObject.Find("restartText").transform.position = new Vector2 (Screen.width / 2, Screen.height / 3 * 1.5f);
			GameObject.Find("mainMenuText").transform.position = new Vector2 (Screen.width / 2, Screen.height / 3 * 1.2f);
            endGameXpText.transform.position = new Vector2(Screen.width / 2, Screen.height / 3 * 0.8f);

            GameObject.Find("defence").transform.position = new Vector2(0 - Screen.width, Screen.height / 3f * 1.9f);
            animcheckgameplay.gameEnd = true;

            if (checkad > 0)
            {
                adboostText.text = "With Ad Boost!";
                adboostText.transform.position = new Vector2(Screen.width / 2, Screen.height / 3 * 0.65f);
            }

            if (recordTimeCheck == false) {
                editRecordTime(time);
                PlayerPrefs.SetInt("roundsplayed", PlayerPrefs.GetInt("roundsplayed") + 1);

                editTimePlayed(time);
                int timeInt = (int)time;
                int totalExp = addExp + timeInt;
            
                
                if (checkad > 0)
                {
                    editExp(totalExp * 2);
                    endGameXpText.text = totalExp * 2 + " Exp Added";
                    PlayerPrefs.SetInt("adUse", PlayerPrefs.GetInt("adUse") - 1);
                }else if (checkad == 0)
                {
                    editExp(totalExp);
                    endGameXpText.text = totalExp + " Exp Added";
                }
                checIfLevel();

                recordTimeCheck = true;
            }
			if( currencyCheck == false){
				editCurrency(dropped);  
				
				currencyCheck = true;
			}
		} 
	}

	public void projHit (int multi){
        

	damage = (int) Projectile.projectileSpeed * multi;
	finalDamage = shieldLife + damage * 3;
	shieldLife += damage * 3;
	if (shieldLife < 0){shieldLife = 0;}
	shieldLifeText.text = "+%" + shieldLife;
	if (finalDamage < 0 ){
		life += finalDamage;
        }
	lifeText.text = "%" + life;
	}

	public void projHitUfo (int multi){
		damage = (int) Projectile.projectileSpeed * multi;
        
		

        int checkad = PlayerPrefs.GetInt("adUse");
        if (checkad <= 0)
        {
            
            dropped += damage * -1;

        }else if (checkad > 0)
        {
            dropped += damage * -2;
        }
        addExp += -1 * damage;
        droppedText.text = "dropped: " + dropped + "$";
    }

	public void LoadLevel (string name){

        int checkad = PlayerPrefs.GetInt("adUse");
        int rounndplayedvalue = PlayerPrefs.GetInt("roundsplayed");

        if (name == "gameplay")
        {
		    Time.timeScale = 1;
		    timeStopped = false;

            if (rounndplayedvalue >= 3)
            {
                if (checkad == 0)
                {
                    if (Advertisement.IsReady())
                    {
                        Application.LoadLevel("add");
                    }
                    else
                    {
                        Application.LoadLevel("gameplay");
                    }

                }
                else if (checkad > 0)
                {
                    Application.LoadLevel("gameplay");
                }
            }else if (rounndplayedvalue == 0)
            {
                Application.LoadLevel("tutorial");
            }
            else
            {
                Application.LoadLevel("gameplay");
            }
            
            
            

		}else
        {
            Application.LoadLevel(name);
        }

            
	}

    public void forceLoadLevel()
    {
        Application.LoadLevel("gameplay");
    }

    public void showAd()
    {
      
       
            Advertisement.Show("rewardedVideo", new ShowOptions() {resultCallback = adRes });
       
    }
    
    public void adRes(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                PlayerPrefs.SetInt("adUse", 3);
                Application.LoadLevel("gameplay");
                break;
            case ShowResult.Skipped:
                Application.LoadLevel("gameplay");
                break;
            case ShowResult.Failed:
                Application.LoadLevel("gameplay");
                break;
        }
    }

 	public void permenantData (){
		PlayerPrefs.SetInt("currency", 0);
		PlayerPrefs.SetInt("recordTime", 0);
		PlayerPrefs.SetFloat("timePlayed", 0);
		PlayerPrefs.SetString("defenceColor", "blue");
		PlayerPrefs.SetString("shieldColor", "blue");
		PlayerPrefs.SetFloat("defenceScale", 1f);
		PlayerPrefs.SetInt("defenceExtendExpense", 0);
		PlayerPrefs.SetInt("currentDefenceLenght", 0);
		PlayerPrefs.SetString("planetState", "earth");
		PlayerPrefs.SetInt("currentShieldLife", 0);
		PlayerPrefs.SetInt("shieldLifeExpense", 0);
		PlayerPrefs.SetInt("currentShieldRegen", 0);
		PlayerPrefs.SetInt("shieldRegenExpense", 0);
        PlayerPrefs.SetInt("USBamount", 0);
        PlayerPrefs.SetInt("exp", 0);
        PlayerPrefs.SetInt("adUse", 0);
    }

	public void resetData (){
		PlayerPrefs.DeleteAll();
	}

	public void buyDefenceScale () {
        if (currency >= PlayerPrefs.GetInt("defenceExtendExpense"))
        {
            if (PlayerPrefs.GetInt("currentDefenceLenght") < 10)
            {
                buybuttonFX.buying();
                PlayerPrefs.SetInt("currentDefenceLenght", PlayerPrefs.GetInt("currentDefenceLenght") + 1);

                editCurrency(-PlayerPrefs.GetInt("defenceExtendExpense"));

                if (PlayerPrefs.GetInt("currentDefenceLenght") == 0) { PlayerPrefs.SetInt("defenceExtendExpense", 0); }
                else if (PlayerPrefs.GetInt("currentDefenceLenght") == 1) { PlayerPrefs.SetInt("defenceExtendExpense", 200); }
                else if (PlayerPrefs.GetInt("currentDefenceLenght") == 2) { PlayerPrefs.SetInt("defenceExtendExpense", 500); }
                else if (PlayerPrefs.GetInt("currentDefenceLenght") == 3) { PlayerPrefs.SetInt("defenceExtendExpense", 1000); }
                else if (PlayerPrefs.GetInt("currentDefenceLenght") == 4) { PlayerPrefs.SetInt("defenceExtendExpense", 2000); }
                else if (PlayerPrefs.GetInt("currentDefenceLenght") == 5) { PlayerPrefs.SetInt("defenceExtendExpense", 3000); }
                else if (PlayerPrefs.GetInt("currentDefenceLenght") == 6) { PlayerPrefs.SetInt("defenceExtendExpense", 5000); }
                else if (PlayerPrefs.GetInt("currentDefenceLenght") == 7) { PlayerPrefs.SetInt("defenceExtendExpense", 7500); }
                else if (PlayerPrefs.GetInt("currentDefenceLenght") == 8) { PlayerPrefs.SetInt("defenceExtendExpense", 10000); }
                else if (PlayerPrefs.GetInt("currentDefenceLenght") == 9) { PlayerPrefs.SetInt("defenceExtendExpense", 15000); }


                showCurrency();
                showDefenceExpanse();
                getDefenceLength();
            }
        }


        if (PlayerPrefs.GetInt("currentDefenceLenght") < 10)
        {
            if (currency < PlayerPrefs.GetInt("defenceExtendExpense"))
            {
                buybuttonFX.cantBuy();
            }
        }
	}


	public void getDefenceLength () {
 
		if (PlayerPrefs.GetInt("currentDefenceLenght") == 0) {getDefenceScale = 1.0f;}
		else if (PlayerPrefs.GetInt("currentDefenceLenght") == 1) {getDefenceScale = 1.2f;}
		else if (PlayerPrefs.GetInt("currentDefenceLenght") == 2) {getDefenceScale = 1.4f;}
		else if (PlayerPrefs.GetInt("currentDefenceLenght") == 3) {getDefenceScale = 1.6f;}
		else if (PlayerPrefs.GetInt("currentDefenceLenght") == 4) {getDefenceScale = 1.8f;}
		else if (PlayerPrefs.GetInt("currentDefenceLenght") == 5) {getDefenceScale = 2.0f;}
        else if (PlayerPrefs.GetInt("currentDefenceLenght") == 6) { getDefenceScale = 2.2f; }
        else if (PlayerPrefs.GetInt("currentDefenceLenght") == 7) { getDefenceScale = 2.4f; }
        else if (PlayerPrefs.GetInt("currentDefenceLenght") == 8) { getDefenceScale = 2.6f; }
        else if (PlayerPrefs.GetInt("currentDefenceLenght") == 9) { getDefenceScale = 2.8f; }
        else if (PlayerPrefs.GetInt("currentDefenceLenght") == 10) { getDefenceScale = 3.0f; }
    }

		public void buyShieldHealth () {
        if (currency >= PlayerPrefs.GetInt("shieldLifeExpense"))
        {
            if (PlayerPrefs.GetInt("currentShieldLife") < 25)
            {
                buybuttonFX.buying();
                PlayerPrefs.SetInt("currentShieldLife", PlayerPrefs.GetInt("currentShieldLife") + 1);

                editCurrency(-PlayerPrefs.GetInt("shieldLifeExpense"));

                if (PlayerPrefs.GetInt("currentShieldLife") == 0) { PlayerPrefs.SetInt("shieldLifeExpense", 0); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 1) { PlayerPrefs.SetInt("shieldLifeExpense", 50); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 2) { PlayerPrefs.SetInt("shieldLifeExpense", 100); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 3) { PlayerPrefs.SetInt("shieldLifeExpense", 150); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 4) { PlayerPrefs.SetInt("shieldLifeExpense", 200); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 5) { PlayerPrefs.SetInt("shieldLifeExpense", 300); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 6) { PlayerPrefs.SetInt("shieldLifeExpense", 400); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 7) { PlayerPrefs.SetInt("shieldLifeExpense", 500); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 8) { PlayerPrefs.SetInt("shieldLifeExpense", 750); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 9) { PlayerPrefs.SetInt("shieldLifeExpense", 1000); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 10) { PlayerPrefs.SetInt("shieldLifeExpense", 1250); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 11) { PlayerPrefs.SetInt("shieldLifeExpense", 1500); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 12) { PlayerPrefs.SetInt("shieldLifeExpense", 2000); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 13) { PlayerPrefs.SetInt("shieldLifeExpense", 2500); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 14) { PlayerPrefs.SetInt("shieldLifeExpense", 3000); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 15) { PlayerPrefs.SetInt("shieldLifeExpense", 3500); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 16) { PlayerPrefs.SetInt("shieldLifeExpense", 4000); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 17) { PlayerPrefs.SetInt("shieldLifeExpense", 5000); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 18) { PlayerPrefs.SetInt("shieldLifeExpense", 6000); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 19) { PlayerPrefs.SetInt("shieldLifeExpense", 7000); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 20) { PlayerPrefs.SetInt("shieldLifeExpense", 8000); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 21) { PlayerPrefs.SetInt("shieldLifeExpense", 9000); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 22) { PlayerPrefs.SetInt("shieldLifeExpense", 10000); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 23) { PlayerPrefs.SetInt("shieldLifeExpense", 12000); }
                else if (PlayerPrefs.GetInt("currentShieldLife") == 24) { PlayerPrefs.SetInt("shieldLifeExpense", 15000); }

                showCurrency();
                showShieldExpense();
                getShieldDure();
            }
        }

        if (PlayerPrefs.GetInt("currentShieldLife") < 25)
        {
            if (currency < PlayerPrefs.GetInt("shieldLifeExpense"))
            {
                buybuttonFX.cantBuy();
            }
        }
    }

	public void getShieldDure () {
 
		if (PlayerPrefs.GetInt("currentShieldLife") == 0) {shieldFullLife = 0;}
		else if (PlayerPrefs.GetInt("currentShieldLife") == 1) {shieldFullLife = 2;}
		else if (PlayerPrefs.GetInt("currentShieldLife") == 2) {shieldFullLife = 4;}
		else if (PlayerPrefs.GetInt("currentShieldLife") == 3) {shieldFullLife = 6;}
		else if (PlayerPrefs.GetInt("currentShieldLife") == 4) {shieldFullLife = 8;}
		else if (PlayerPrefs.GetInt("currentShieldLife") == 5) {shieldFullLife = 10;}
        else if (PlayerPrefs.GetInt("currentShieldLife") == 6) { shieldFullLife = 12; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 7) { shieldFullLife = 14; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 8) { shieldFullLife = 16; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 9) { shieldFullLife = 18; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 10) { shieldFullLife = 20; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 11) { shieldFullLife = 22; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 12) { shieldFullLife = 24; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 13) { shieldFullLife = 26; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 14) { shieldFullLife = 28; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 15) { shieldFullLife = 30; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 16) { shieldFullLife = 32; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 17) { shieldFullLife = 34; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 18) { shieldFullLife = 36; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 19) { shieldFullLife = 38; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 20) { shieldFullLife = 40; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 21) { shieldFullLife = 42; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 22) { shieldFullLife = 44; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 23) { shieldFullLife = 46; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 24) { shieldFullLife = 48; }
        else if (PlayerPrefs.GetInt("currentShieldLife") == 25) { shieldFullLife = 50; }

    }

    public void buyShieldRegen () {
        if (currency >= PlayerPrefs.GetInt("shieldRegenExpense"))
        {
            if (PlayerPrefs.GetInt("currentShieldRegen") < 5)
            {
                buybuttonFX.buying();
                PlayerPrefs.SetInt("currentShieldRegen", PlayerPrefs.GetInt("currentShieldRegen") + 1);

                editCurrency(-PlayerPrefs.GetInt("shieldRegenExpense"));

                if (PlayerPrefs.GetInt("currentShieldRegen") == 0) { PlayerPrefs.SetInt("shieldRegenExpense", 0); }
                else if (PlayerPrefs.GetInt("currentShieldRegen") == 1) { PlayerPrefs.SetInt("shieldRegenExpense", 1000); }
                else if (PlayerPrefs.GetInt("currentShieldRegen") == 2) { PlayerPrefs.SetInt("shieldRegenExpense", 3000); }
                else if (PlayerPrefs.GetInt("currentShieldRegen") == 3) { PlayerPrefs.SetInt("shieldRegenExpense", 5000); }
                else if (PlayerPrefs.GetInt("currentShieldRegen") == 4) { PlayerPrefs.SetInt("shieldRegenExpense", 8000); }


                showCurrency();
                showShieldExpense();
                getShieldRegenTime();
            }
        }

        if (PlayerPrefs.GetInt("currentShieldRegen") < 5)
        {
            if (currency < PlayerPrefs.GetInt("shieldRegenExpense"))
            {
                buybuttonFX.cantBuy();
            }
        }
    }

	public void getShieldRegenTime () {
 
		if (PlayerPrefs.GetInt("currentShieldRegen") == 0) {shieldRegenTime = 6;}
		else if (PlayerPrefs.GetInt("currentShieldRegen") == 1) {shieldRegenTime = 5;}
		else if (PlayerPrefs.GetInt("currentShieldRegen") == 2) {shieldRegenTime = 4;}
		else if (PlayerPrefs.GetInt("currentShieldRegen") == 3) {shieldRegenTime = 3;}
		else if (PlayerPrefs.GetInt("currentShieldRegen") == 4) {shieldRegenTime = 2;}
		else if (PlayerPrefs.GetInt("currentShieldRegen") == 5) {shieldRegenTime = 1;}
	}

    public void setUlt(string color, bool bought)
    {
        if (color == "shieldUlt")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 2000)
                {
                    buybuttonFX.buying();
                    print("got currency shield");
                    editCurrency(-2000);
                    upgradeAbility.shieldUltBuy();
                    showCurrency();
                  
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {

                print("already bought shield");
            }
        }

        if (color == "defenceUlt")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 6000)
                {
                    buybuttonFX.buying();
                    editCurrency(-6000);
                    upgradeAbility.defenceUltBuy();
                    showCurrency();
                    print("got currency stick");
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {

                print("already bought time");
            }

        }

        if (color == "timeUlt")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 9000)
                {
                    buybuttonFX.buying();
                    editCurrency(-9000);
                    upgradeAbility.timeUltBuy();
                    showCurrency();
                    print("time ult currency got");
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {

                print("already bought time");
            }
        }
    }


        public void setDefenceColor (string color, bool bought){
		
		if (color == "red"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 500) {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("defenceColor", "red");
					editCurrency(-500);
					buyDefenceColor.redColorBought();
					showCurrency();
					getDefenceColor();	
				}
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("defenceColor", "red");
				getDefenceColor();
			}
		}

		if (color == "blue"){
			if (bought == false){
                buybuttonFX.equip();
                PlayerPrefs.SetString("defenceColor", "blue");
					buyDefenceColor.blueColorBought();
					getDefenceColor();	
				
			}
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("defenceColor", "blue");
				getDefenceColor();
			}
		}

		if (color == "green"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 500) {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("defenceColor", "green");
					editCurrency(-500);
					buyDefenceColor.greenColorBought();
					showCurrency();
					getDefenceColor();	
				}
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("defenceColor", "green");
				getDefenceColor();
			}
		}

		if (color == "yellow"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 500) {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("defenceColor", "yellow");
					editCurrency(-500);
					buyDefenceColor.yellowColorBought();
					showCurrency();
					getDefenceColor();	
				}
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("defenceColor", "yellow");
				getDefenceColor();
			}
		}

		if (color == "purple"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 500) {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("defenceColor", "purple");
					editCurrency(-500);
					buyDefenceColor.purpleColorBought();
					showCurrency();
					getDefenceColor();	
				}
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("defenceColor", "purple");
				getDefenceColor();
			}
		}

		if (color == "pink"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 500) {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("defenceColor", "pink");
					editCurrency(-500);
					buyDefenceColor.pinkColorBought();
					showCurrency();
					getDefenceColor();	
				}
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("defenceColor", "pink");
				getDefenceColor();
			}
		}

        if (color == "white")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 500)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("defenceColor", "white");
                    editCurrency(-500);
                    buyDefenceColor.whiteColorBought();
                    showCurrency();
                    getDefenceColor();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("defenceColor", "white");
                getDefenceColor();
            }
        }

        if (color == "orange")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 500)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("defenceColor", "orange");
                    editCurrency(-500);
                    buyDefenceColor.orangeColorBought();
                    showCurrency();
                    getDefenceColor();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("defenceColor", "orange");
                getDefenceColor();
            }
        }

        if (color == "navy")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 500)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("defenceColor", "navy");
                    editCurrency(-500);
                    buyDefenceColor.navyColorBought();
                    showCurrency();
                    getDefenceColor();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("defenceColor", "navy");
                getDefenceColor();
            }
        }

        if (color == "brown")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 500)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("defenceColor", "brown");
                    editCurrency(-500);
                    buyDefenceColor.brownColorBought();
                    showCurrency();
                    getDefenceColor();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("defenceColor", "brown");
                getDefenceColor();
            }
        }

        if (color == "dgreen")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 500)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("defenceColor", "dgreen");
                    editCurrency(-500);
                    buyDefenceColor.dgreenColorBought();
                    showCurrency();
                    getDefenceColor();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("defenceColor", "dgreen");
                getDefenceColor();
            }
        }

        if (color == "silver")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 500)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("defenceColor", "silver");
                    editCurrency(-500);
                    buyDefenceColor.silverColorBought();
                    showCurrency();
                    getDefenceColor();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("defenceColor", "silver");
                getDefenceColor();
            }
        }


    }

	public void getDefenceColor (){
		if (PlayerPrefs.GetString("defenceColor") == "blue"){currentDefenceColor = "blue";}
		else if (PlayerPrefs.GetString("defenceColor") == "red"){currentDefenceColor = "red";}
		else if (PlayerPrefs.GetString("defenceColor") == "green"){currentDefenceColor = "green";}
		else if (PlayerPrefs.GetString("defenceColor") == "pink"){currentDefenceColor = "pink";}
		else if (PlayerPrefs.GetString("defenceColor") == "purple"){currentDefenceColor = "purple";}
		else if (PlayerPrefs.GetString("defenceColor") == "yellow"){currentDefenceColor = "yellow";}
        else if (PlayerPrefs.GetString("defenceColor") == "white") { currentDefenceColor = "white"; }
        else if (PlayerPrefs.GetString("defenceColor") == "orange") { currentDefenceColor = "orange"; }
        else if (PlayerPrefs.GetString("defenceColor") == "navy") { currentDefenceColor = "navy"; }
        else if (PlayerPrefs.GetString("defenceColor") == "brown") { currentDefenceColor = "brown"; }
        else if (PlayerPrefs.GetString("defenceColor") == "dgreen") { currentDefenceColor = "dgreen"; }
        else if (PlayerPrefs.GetString("defenceColor") == "silver") { currentDefenceColor = "silver"; }
    }

	public void setShieldColor(string color, bool bought) {
		if (color == "red"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 1000) {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("shieldColor", "red");
					editCurrency(-1000);
					buyShieldColor.redColorBought();
					showCurrency();
					getDefenceColor();	
				}
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("shieldColor", "red");
				getDefenceColor();
			}
		}

		if (color == "blue"){
			if (bought == false){
                buybuttonFX.equip();
                PlayerPrefs.SetString("shieldColor", "blue");
					buyShieldColor.blueColorBought();
					getDefenceColor();	
				
			}
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("shieldColor", "blue");
				getDefenceColor();
			}
		}

		if (color == "green"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 1000) {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("shieldColor", "green");
					editCurrency(-1000);
					buyShieldColor.greenColorBought();
					showCurrency();
					getDefenceColor();	
				}
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("shieldColor", "green");
				getDefenceColor();
			}
		}

		if (color == "yellow"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 1000) {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("shieldColor", "yellow");
					editCurrency(-1000);
					buyShieldColor.yellowColorBought();
					showCurrency();
					getDefenceColor();	
				}
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("shieldColor", "yellow");
				getDefenceColor();
			}
		}

		if (color == "purple"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 1000) {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("shieldColor", "purple");
					editCurrency(-1000);
					buyShieldColor.purpleColorBought();
					showCurrency();
					getDefenceColor();	
				}
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("shieldColor", "purple");
				getDefenceColor();
			}
		}

		if (color == "pink"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 1000) {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("shieldColor", "pink");
					editCurrency(-1000);
					buyShieldColor.pinkColorBought();
					showCurrency();
					getDefenceColor();	
				}
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("shieldColor", "pink");
				getDefenceColor();
			}
		}

        if (color == "white")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 1000)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("shieldColor", "white");
                    editCurrency(-1000);
                    buyShieldColor.whiteColorBought();
                    showCurrency();
                    getDefenceColor();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("shieldColor", "white");
                getDefenceColor();
            }
        }

        if (color == "orange")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 1000)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("shieldColor", "orange");
                    editCurrency(-1000);
                    buyShieldColor.orangeColorBought();
                    showCurrency();
                    getDefenceColor();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("shieldColor", "orange");
                getDefenceColor();
            }
        }

        if (color == "navy")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 1000)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("shieldColor", "navy");
                    editCurrency(-1000);
                    buyShieldColor.navyColorBought();
                    showCurrency();
                    getDefenceColor();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("shieldColor", "navy");
                getDefenceColor();
            }
        }

        if (color == "brown")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 1000)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("shieldColor", "brown");
                    editCurrency(-1000);
                    buyShieldColor.brownColorBought();
                    showCurrency();
                    getDefenceColor();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("shieldColor", "brown");
                getDefenceColor();
            }
        }

        if (color == "dgreen")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 1000)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("shieldColor", "dgreen");
                    editCurrency(-1000);
                    buyShieldColor.dgreenColorBought();
                    showCurrency();
                    getDefenceColor();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("shieldColor", "dgreen");
                getDefenceColor();
            }
        }

        if (color == "silver")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 1000)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("shieldColor", "silver");
                    editCurrency(-1000);
                    buyShieldColor.silverColorBought();
                    showCurrency();
                    getDefenceColor();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("shieldColor", "silver");
                getDefenceColor();
            }
        }
    }

	public void getShieldColor (){
		if (PlayerPrefs.GetString("shieldColor") == "blue"){currentShieldColor = "blue";}
		else if (PlayerPrefs.GetString("shieldColor") == "red"){currentShieldColor = "red";}
		else if (PlayerPrefs.GetString("shieldColor") == "green"){currentShieldColor = "green";}
		else if (PlayerPrefs.GetString("shieldColor") == "pink"){currentShieldColor = "pink";}
		else if (PlayerPrefs.GetString("shieldColor") == "purple"){currentShieldColor = "purple";}
		else if (PlayerPrefs.GetString("shieldColor") == "yellow"){currentShieldColor = "yellow";}
        else if (PlayerPrefs.GetString("shieldColor") == "white") { currentShieldColor = "white"; }
        else if (PlayerPrefs.GetString("shieldColor") == "orange") { currentShieldColor = "orange"; }
        else if (PlayerPrefs.GetString("shieldColor") == "navy") { currentShieldColor = "navy"; }
        else if (PlayerPrefs.GetString("shieldColor") == "brown") { currentShieldColor = "brown"; }
        else if (PlayerPrefs.GetString("shieldColor") == "dgreen") { currentShieldColor = "dgreen"; }
        else if (PlayerPrefs.GetString("shieldColor") == "silver") { currentShieldColor = "silver"; }
    }

	public void setPlanet(string planet, bool bought){
		if (planet == "mars"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 3000) {
                    buybuttonFX.buying();
					PlayerPrefs.SetString("planetState", "mars");
					editCurrency(-3000);
					buyPlanet.marsPlanetBought();
					showCurrency();
					getPlanet();	
				}else
                {
                    buybuttonFX.cantBuy();
                }
			}
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("planetState", "mars");
				getPlanet();
			}
		}

		if (planet == "earth"){
			if (bought == false){
				
					PlayerPrefs.SetString("planetState", "earth");
                buybuttonFX.equip();
                //	editCurrency(-3000);
                buyPlanet.earthPlanetBought();
				//	showCurrency();
					getPlanet();	
				
			}
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("planetState", "earth");
				getPlanet();
			}
		}

		if (planet == "saturn"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 3000) {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("planetState", "saturn");
					editCurrency(-3000);
					buyPlanet.saturnPlanetBought();
					showCurrency();
					getPlanet();	
				}
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("planetState", "saturn");
				getPlanet();
			}
		}

		if (planet == "neptune"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 3000) {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("planetState", "neptune");
					editCurrency(-3000);
					buyPlanet.neptunePlanetBought();
					showCurrency();
					getPlanet();	
				}
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("planetState", "neptune");
				getPlanet();
			}
		}

		if (planet == "jupiter"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 3000) {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("planetState", "jupiter");
					editCurrency(-3000);
					buyPlanet.jupiterPlanetBought();
					showCurrency();
					getPlanet();	
				}
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("planetState", "jupiter");
				getPlanet();
			}
		}

		if (planet == "mercury"){
			if (bought == false){
				if (PlayerPrefs.GetInt("currency") >= 3000) {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("planetState", "mercury");
					editCurrency(-3000);
					buyPlanet.mercuryPlanetBought();
					showCurrency();
					getPlanet();	
				}
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
			else if (bought == true){
                buybuttonFX.equip();
                PlayerPrefs.SetString("planetState", "mercury");
				getPlanet();
			}
		}

        if (planet == "venus")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 3000)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("planetState", "venus");
                    editCurrency(-3000);
                    buyPlanet.venusPlanetBought();
                    showCurrency();
                    getPlanet();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("planetState", "venus");
                getPlanet();
            }
        }

        if (planet == "uranus")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 3000)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("planetState", "uranus");
                    editCurrency(-3000);
                    buyPlanet.uranusPlanetBought();
                    showCurrency();
                    getPlanet();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("planetState", "uranus");
                getPlanet();
            }
        }

        if (planet == "moon")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 2000)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("planetState", "moon");
                    editCurrency(-2000);
                    buyPlanet.moonPlanetBought();
                    showCurrency();
                    getPlanet();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("planetState", "moon");
                getPlanet();
            }
        }

        if (planet == "europa")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 2000)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("planetState", "europa");
                    editCurrency(-2000);
                    buyPlanet.europaPlanetBought();
                    showCurrency();
                    getPlanet();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("planetState", "europa");
                getPlanet();
            }
        }

        if (planet == "mimas")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 2000)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("planetState", "mimas");
                    editCurrency(-2000);
                    buyPlanet.mimasPlanetBought();
                    showCurrency();
                    getPlanet();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("planetState", "mimas");
                getPlanet();
            }
        }

        if (planet == "ganymade")
        {
            if (bought == false)
            {
                if (PlayerPrefs.GetInt("currency") >= 2000)
                {
                    buybuttonFX.buying();
                    PlayerPrefs.SetString("planetState", "ganymade");
                    editCurrency(-2000);
                    buyPlanet.ganymadePlanetBought();
                    showCurrency();
                    getPlanet();
                }
                else
                {
                    buybuttonFX.cantBuy();
                }
            }
            else if (bought == true)
            {
                buybuttonFX.equip();
                PlayerPrefs.SetString("planetState", "ganymade");
                getPlanet();
            }
        }

    }

	public void getPlanet (){
		if (PlayerPrefs.GetString("planetState") == "mars"){currentPlanet = "mars";}
		else if (PlayerPrefs.GetString("planetState") == "earth"){currentPlanet = "earth";}
		else if (PlayerPrefs.GetString("planetState") == "saturn"){currentPlanet = "saturn";}
		else if (PlayerPrefs.GetString("planetState") == "neptune"){currentPlanet = "neptune";}
		else if (PlayerPrefs.GetString("planetState") == "jupiter"){currentPlanet = "jupiter";}
		else if (PlayerPrefs.GetString("planetState") == "mercury"){currentPlanet = "mercury";}
        else if (PlayerPrefs.GetString("planetState") == "venus") { currentPlanet = "venus"; }
        else if (PlayerPrefs.GetString("planetState") == "uranus") { currentPlanet = "uranus"; }
        else if (PlayerPrefs.GetString("planetState") == "moon") { currentPlanet = "moon"; }
        else if (PlayerPrefs.GetString("planetState") == "europa") { currentPlanet = "europa"; }
        else if (PlayerPrefs.GetString("planetState") == "mimas") { currentPlanet = "mimas"; }
        else if (PlayerPrefs.GetString("planetState") == "ganymade") { currentPlanet = "ganymade"; }
    }

	

		

	public void editCurrency (int edit){
		PlayerPrefs.SetInt("currency", PlayerPrefs.GetInt("currency") + edit);
	}

    public void editUSB(int edit)
    {
        PlayerPrefs.SetInt("USBamount", PlayerPrefs.GetInt("USBamount") + edit);
    }

    public void editExp(int edit)
    {
        PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") + edit);
    }

    public void checIfLevel()
    {
        int expToInt = (int)PlayerPrefs.GetInt("exp");
        if (expToInt >= 3000)
        {
            newUSB.transform.position = new Vector2(Screen.width / 2, Screen.height / 3 * 0.3f);
            int getusbint = expToInt / 3000;
            editUSB(+getusbint);
            PlayerPrefs.SetInt("exp", PlayerPrefs.GetInt("exp") - 3000 * getusbint);
        }
    }

    public void editTimePlayed (float edit){
		PlayerPrefs.SetFloat("timePlayed", PlayerPrefs.GetFloat("timePlayed") + edit);
	}

	public void showTimePlayed (){
        timePlayed = (int)PlayerPrefs.GetFloat("timePlayed");

        if (timePlayed < 60)
        {
            timePlayedText.text = "Total Time Played: " + timePlayed + "s";
        }
        else if (timePlayed >= 60 && timePlayed < 3600)
        {
            int min = timePlayed / 60;
            timePlayedText.text = "Total Time Played: " + min + "m " + (timePlayed - 60 * min) + "s";
        }else if (timePlayed >= 3600)
        {
            int hour = timePlayed / 3600;
            int min = (timePlayed - 3600 * hour) / 60;
            timePlayedText.text = "Total Time Played: " + hour + "h " + min + "m " + ((timePlayed - 3600 * hour) - 60 * min) + "s";
        }

	}

	public void editRecordTime (float edit){
		int timeInt = (int) edit;
		if (timeInt > PlayerPrefs.GetInt("recordTime")){
		PlayerPrefs.SetInt("recordTime", timeInt);
            recordText.transform.position = new Vector3(Screen.width / 5 * 2.8f, Screen.height / 5 * 4.3f);
		}
	}
	public void showCurrency (){
		currency = PlayerPrefs.GetInt("currency");
		currencyText.text = "Currency: " + currency + "$";		
	}   

    public void showExp()
    {
        int expToInt = (int) PlayerPrefs.GetInt("exp");
        expText.text = expToInt + " / 3000 Exp for USB";
       
    }

    public void showShieldExpense () {
		if (PlayerPrefs.GetInt("currentShieldLife") == 0){
			shieldLifeExpenseText.text = "Free!";
		}
		else if (PlayerPrefs.GetInt("currentShieldLife") == 25){
			shieldLifeExpenseText.text = "Full";
		}else{
			shieldLifeExpenseText.text = "-" +  PlayerPrefs.GetInt("shieldLifeExpense") + "$";
		}
		shieldLifeStateText.text = "%" + PlayerPrefs.GetInt("currentShieldLife") * 2 + "\n" +  PlayerPrefs.GetInt("currentShieldLife") + "/25";


        if (PlayerPrefs.GetInt("currentShieldRegen") == 0)
        {
            shieldRegenExpenseText.text = "Free!";
        }
        else if (PlayerPrefs.GetInt("currentShieldRegen") == 5){
			shieldRegenExpenseText.text = "Full";
		
		}else{
			shieldRegenExpenseText.text = "-" +  PlayerPrefs.GetInt("shieldRegenExpense") + "$";	
		}
		shieldRegenStateText.text = 6 - PlayerPrefs.GetInt("currentShieldRegen") + "s\n" +  PlayerPrefs.GetInt("currentShieldRegen") + "/5";
	}

	public void showDefenceExpanse (){
		if (PlayerPrefs.GetInt("currentDefenceLenght") == 0){
			defenceExtendExpenseText.text = "Free!";
		}
		else if (PlayerPrefs.GetInt("currentDefenceLenght") == 10){
			defenceExtendExpenseText.text = "Full";
		}else{
			defenceExtendExpenseText.text = "-" +  PlayerPrefs.GetInt("defenceExtendExpense") + "$";
		}
		
		defenceLengthText.text = PlayerPrefs.GetInt("currentDefenceLenght")  + "/10";
		
	}

	public void showRecordTime (){
		recordTime = PlayerPrefs.GetInt("recordTime");
        if (recordTime < 60)
        {
            recordTimeText.text = "Best Defence: " + recordTime + "s";
        }
        else if (recordTime >= 60)
        {
            int min = recordTime / 60;
            recordTimeText.text = "Best Defence: " + min + "m " + (recordTime - 60 * min) + "s";
        }

	}

	public void setTimeOne (){
		Time.timeScale = 1;
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
