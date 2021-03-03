using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradeAbility : MonoBehaviour
{
    public GameManager gameManager;
    public bool shieldUltBought;
    public bool defenceUltBought;
    public bool timeUltBought;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void savedData()
    {
        PlayerPrefs.SetInt("shieldUltBought", 0);
        PlayerPrefs.SetInt("defenceUltBought", 0);
        PlayerPrefs.SetInt("timeUltBought", 0);
    }


    public void checkIfBuyed(string color)
    {
        prefToBool();

        if (color == "shieldUlt")
        {
            print("shield button pressed");
            gameManager.setUlt(color, shieldUltBought);
        }

        if (color == "defenceUlt")
        {
            print("defence ult button pressed");
            gameManager.setUlt(color, defenceUltBought);
        }

        if (color == "timeUlt")
        {
            print("time ult button pressed");
            gameManager.setUlt(color, timeUltBought);
        }
    }

    public void prefToBool()
    {
        int shieldUltBoughtValue = (PlayerPrefs.GetInt("shieldUltBought"));
        if (shieldUltBoughtValue == 0) { shieldUltBought = false; }
        else if (shieldUltBoughtValue == 1) { shieldUltBought = true; }

        int defenceUltBoughtValue = (PlayerPrefs.GetInt("defenceUltBought"));
        if (defenceUltBoughtValue == 0) { defenceUltBought = false; }
        else if (defenceUltBoughtValue == 1) { defenceUltBought = true; }

        int timeUltBoughtValue = (PlayerPrefs.GetInt("timeUltBought"));
        if (timeUltBoughtValue == 0) { timeUltBought = false; }
        else if (timeUltBoughtValue == 1) { timeUltBought = true; }

        print("trans to bool");
    }


    public void shieldUltBuy() 
    {
        PlayerPrefs.SetInt("shieldUltBought", 1);
        print("shield check in");
    }

    public void defenceUltBuy()
    {
        PlayerPrefs.SetInt("defenceUltBought", 1);
        print("defence check in");
    }

    public void timeUltBuy()
    {
        PlayerPrefs.SetInt("timeUltBought", 1);
        print("time checkin");
    }

}
