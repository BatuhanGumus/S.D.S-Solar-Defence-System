using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxSystem : MonoBehaviour {
    public buyDefenceColor buyDefenceColor;
    public buyShieldColor buyShieldColor;
    public buyPlanet buyPlanet;
    public int chooseCatagory;
    public int chooseDefenceColor;
    public int chooseShieldColor;
    public int choosePlanet;
    public int chooseMoon;
    public Text gotItem;
    public Text onUSB;
    public GameManager gameManager;
    public bool moveText = false;

    public AudioClip okay;
    public AudioClip error;

    AudioSource audio;
    // Use this for initialization
    void Start () {
        audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
        if (moveText == true) {
            gotItem.transform.position += Vector3.right * Screen.width / 3 * Time.deltaTime;
        }
        if (gotItem.transform.position.x > Screen.width * 3 / 2) { moveText = false; }
        

        int currentUSB = PlayerPrefs.GetInt("USBamount");
        if (currentUSB == 0)
        {
            onUSB.color = new Color(1f, 0f, 0f, 0.7f);
            onUSB.text = "X";
        } else
        {
            onUSB.color = new Color(0f, 1f, 1f, 0.7f);
            onUSB.text = "" + currentUSB;
        }
    }

    public void randomItem(){
        
        

        gameManager.showCurrency();

        buyDefenceColor.prefToBool();
        buyShieldColor.prefToBool();
        buyPlanet.prefToBool();

        int currentUSB = PlayerPrefs.GetInt("USBamount");

        if (currentUSB > 0)
        {
            audio.clip = okay;
            audio.Play();
            gotItem.transform.position = new Vector2(0 - Screen.width / 2, Screen.height / 5f * 1.4f);
            moveText = true;
            gameManager.editUSB(-1);

            chooseCatagory = Random.Range(1, 10 + 1);

            if (chooseCatagory == 1 || chooseCatagory == 2 || chooseCatagory == 3 || chooseCatagory == 4)
            {
                chooseDefenceColor = Random.Range(1, 11 + 1);
                chooseRandomDefenceColor();
            }
            else if (chooseCatagory == 5 || chooseCatagory == 6 || chooseCatagory == 7)
            {
                chooseShieldColor = Random.Range(1, 11 + 1);
                chooseRandomShieldColor();
            }
            else if (chooseCatagory == 8 || chooseCatagory == 9)
            {
                chooseMoon = Random.Range(1, 4 + 1);
                chooseRandomMoon();
            }
            else if (chooseCatagory == 10)
            {
                choosePlanet = Random.Range(1, 7 + 1);
                chooseRandomPlanet();
            }
        }
        else
        {
            audio.clip = error;
            audio.Play();
        }
    }
	public void chooseRandomDefenceColor(){


        if (chooseDefenceColor == 1) {
           
            if (buyDefenceColor.redBought == false)
            {
                PlayerPrefs.SetInt("redBought", 1);
                gotItem.text = "Red Defence";
                gotItem.transform.position += Vector3.right * Time.deltaTime;
            }
            else if (buyDefenceColor.redBought == true)
            {
                gotItem.text = "Red Defence  +250$";
                gameManager.editCurrency(+250);
            }
        }
        else if (chooseDefenceColor == 2) {
            if (buyDefenceColor.pinkBought == false)
            {
                PlayerPrefs.SetInt("pinkBought", 1);
                gotItem.text = "Pink Defence";
            }
            else if (buyDefenceColor.pinkBought == true)
            {
                gotItem.text = "Pink Defence  +250$";
                gameManager.editCurrency(+250);
            }
              
        }
        else if (chooseDefenceColor == 3) {
            if (buyDefenceColor.greenBought == false)
            {
                PlayerPrefs.SetInt("greenBought", 1);
                gotItem.text = "green Defence";
            }
            else if (buyDefenceColor.greenBought == true)
            {
                gotItem.text = "green Defence  +250$";
                gameManager.editCurrency(+250); 
            }   
        }
        else if (chooseDefenceColor == 4) {
            if (buyDefenceColor.yellowBought == false)
            {
                PlayerPrefs.SetInt("yellowBought", 1);
                gotItem.text = "Yellow Defence";
            }
            else if (buyDefenceColor.yellowBought == true)
            {
                gotItem.text = "Yellow Defence  +250$";
                gameManager.editCurrency(+250);
            }
            
            
        }
        else if (chooseDefenceColor == 5) {
            if (buyDefenceColor.purpleBought == false)
            {
                PlayerPrefs.SetInt("purpleBought", 1);
                gotItem.text = "Purple Defence";
            }
            else if (buyDefenceColor.purpleBought == true)
            {
                gotItem.text = "Purple Defence  +250$";
                gameManager.editCurrency(+250);
            }      
        }
        else if (chooseDefenceColor == 6)
        {
            if (buyDefenceColor.whiteBought == false)
            {
                PlayerPrefs.SetInt("whiteBought", 1);
                gotItem.text = "White Defence";
            }
            else if (buyDefenceColor.whiteBought == true)
            {
                gotItem.text = "White Defence  +250$";
                gameManager.editCurrency(+250);
            }
        }
        else if (chooseDefenceColor == 7)
        {
            if (buyDefenceColor.orangeBought == false)
            {
                PlayerPrefs.SetInt("orangeBought", 1);
                gotItem.text = "Orange Defence";
            }
            else if (buyDefenceColor.orangeBought == true)
            {
                gotItem.text = "Orange Defence  +250$";
                gameManager.editCurrency(+250);
            }
        }
        else if (chooseDefenceColor == 8)
        {
            if (buyDefenceColor.navyBought == false)
            {
                PlayerPrefs.SetInt("navyBought", 1);
                gotItem.text = "Dark Blue Defence";
            }
            else if (buyDefenceColor.navyBought == true)
            {
                gotItem.text = "Dark Blue Defence  +250$";
                gameManager.editCurrency(+250);
            }
        }
        else if (chooseDefenceColor == 9)
        {
            if (buyDefenceColor.brownBought == false)
            {
                PlayerPrefs.SetInt("brownBought", 1);
                gotItem.text = "Brown Defence";
            }
            else if (buyDefenceColor.brownBought == true)
            {
                gotItem.text = "Brown Defence  +250$";
                gameManager.editCurrency(+250);
            }
        }
        else if (chooseDefenceColor == 10)
        {
            if (buyDefenceColor.dgreenBought == false)
            {
                PlayerPrefs.SetInt("dgreenBought", 1);
                gotItem.text = "Dark Green Defence";
            }
            else if (buyDefenceColor.dgreenBought == true)
            {
                gotItem.text = "Dark Green Defence  +250$";
                gameManager.editCurrency(+250);
            }
        }
        else if (chooseDefenceColor == 11)
        {
            if (buyDefenceColor.silverBought == false)
            {
                PlayerPrefs.SetInt("silverBought", 1);
                gotItem.text = "Silver Defence";
            }
            else if (buyDefenceColor.silverBought == true)
            {
                gotItem.text = "Silver Defence  +250$";
                gameManager.editCurrency(+250);
            }
        }
    }
    public void chooseRandomShieldColor()
    {
         if (chooseShieldColor == 1)
         {
            if (buyShieldColor.redBought == false)
            {
                PlayerPrefs.SetInt("redShieldBought", 1);
                gotItem.text = "Red Shield";
            }
            else if (buyShieldColor.redBought == true)
            {
                gotItem.text = "Red Shield  +500$";
                gameManager.editCurrency(+500);
            }
        }
        else if (chooseShieldColor == 2)
        {
            if (buyShieldColor.greenBought == false)
            {
                PlayerPrefs.SetInt("greenShieldBought", 1);
                gotItem.text = "Green Shield";
            }
            else if (buyShieldColor.greenBought == true)
            {
                gotItem.text = "Green Shield  +500$";
                gameManager.editCurrency(+500);
            }
        }
        else if (chooseShieldColor == 3)
        {
            if (buyShieldColor.yellowBought == false)
            {
                PlayerPrefs.SetInt("yellowShieldBought", 1);
                gotItem.text = "Yellow Shield";
            }
            else if (buyShieldColor.yellowBought == true)
            {
                gotItem.text = "Yellow Shield  +500$";
                gameManager.editCurrency(+500);
            }
        }
        else if (chooseShieldColor == 4)
        {
            if (buyShieldColor.purpleBought == false)
            {
                PlayerPrefs.SetInt("purpleShieldBought", 1);
                gotItem.text = "Purple Shield";
            }
            else if (buyShieldColor.purpleBought == true)
            {
                gotItem.text = "Purple Shield  +500$";
                gameManager.editCurrency(+500);
            }
        }
        else if (chooseShieldColor == 5)
        {
            if (buyShieldColor.pinkBought == false)
            {
                PlayerPrefs.SetInt("pinkShieldBought", 1);
                gotItem.text = "Pink Shield";
            }
            else if (buyShieldColor.pinkBought == true)
            {
                gotItem.text = "Pink Shield  +500$";
                gameManager.editCurrency(+500);
            }
        }
        else if (chooseShieldColor == 6)
        {
            if (buyShieldColor.whiteBought == false)
            {
                PlayerPrefs.SetInt("whiteShieldBought", 1);
                gotItem.text = "White Shield";
            }
            else if (buyShieldColor.whiteBought == true)
            {
                gotItem.text = "White Shield  +500$";
                gameManager.editCurrency(+500);
            }
        }
        else if (chooseShieldColor == 7)
        {
            if (buyShieldColor.orangeBought == false)
            {
                PlayerPrefs.SetInt("orangeShieldBought", 1);
                gotItem.text = "Orange Shield";
            }
            else if (buyShieldColor.orangeBought == true)
            {
                gotItem.text = "Orange Shield  +500$";
                gameManager.editCurrency(+500);
            }
        }
        else if (chooseShieldColor == 8)
        {
            if (buyShieldColor.navyBought == false)
            {
                PlayerPrefs.SetInt("navyShieldBought", 1);
                gotItem.text = "Dark Blue Shield";
            }
            else if (buyShieldColor.navyBought == true)
            {
                gotItem.text = "Darl Blue Shield  +500$";
                gameManager.editCurrency(+500);
            }
        }
        else if (chooseShieldColor == 9)
        {
            if (buyShieldColor.brownBought == false)
            {
                PlayerPrefs.SetInt("brownShieldBought", 1);
                gotItem.text = "Brown Shield";
            }
            else if (buyShieldColor.brownBought == true)
            {
                gotItem.text = "Brown Shield  +500$";
                gameManager.editCurrency(+500);
            }
        }
        else if (chooseShieldColor == 10)
        {
            if (buyShieldColor.dgreenBought == false)
            {
                PlayerPrefs.SetInt("dgreenShieldBought", 1);
                gotItem.text = "Dark Green Shield";
            }
            else if (buyShieldColor.dgreenBought == true)
            {
                gotItem.text = "Dark Green Shield  +500$";
                gameManager.editCurrency(+500);
            }
        }
        else if (chooseShieldColor == 11)
        {
            if (buyShieldColor.silverBought == false)
            {
                PlayerPrefs.SetInt("silverShieldBought", 1);
                gotItem.text = "Silver Shield";
            }
            else if (buyShieldColor.silverBought == true)
            {
                gotItem.text = "Silver Shield  +500$";
                gameManager.editCurrency(+500);
            }
        }
    }
    public void chooseRandomMoon()
    {
        if (chooseMoon == 1)
        {
            if (buyPlanet.moonBought == false)
            {
                PlayerPrefs.SetInt("moonBought", 1);
                gotItem.text = "Moon";
            }
            else if (buyPlanet.moonBought == true)
            {
                gotItem.text = "Moon   +1000$";
                gameManager.editCurrency(+1000);
            }
        }

        if (chooseMoon == 2)
        {
            if (buyPlanet.europaBought == false)
            {
                PlayerPrefs.SetInt("europaBought", 1);
                gotItem.text = "Europa";
            }
            else if (buyPlanet.europaBought == true)
            {
                gotItem.text = "Europa   +1000$";
                gameManager.editCurrency(+1000);
            }
        }

        if (chooseMoon == 3)
        {
            if (buyPlanet.mimasBought == false)
            {
                PlayerPrefs.SetInt("mimasBought", 1);
                gotItem.text = "Mimas";
            }
            else if (buyPlanet.mimasBought == true)
            {
                gotItem.text = "Mimas   +1000$";
                gameManager.editCurrency(+1000);
            }
        }

        if (chooseMoon == 4)
        {
            if (buyPlanet.ganymadeBought == false)
            {
                PlayerPrefs.SetInt("ganymadeBought", 1);
                gotItem.text = "Ganymade";
            }
            else if (buyPlanet.ganymadeBought == true)
            {
                gotItem.text = "Ganymade   +1000$";
                gameManager.editCurrency(+1000);
            }
        }
    }
    public void chooseRandomPlanet()
    {
        if (choosePlanet == 1)
        {
            if (buyPlanet.saturnBought == false)
            {
                PlayerPrefs.SetInt("saturnBought", 1);
                gotItem.text = "Saturn";
            }
            else if (buyPlanet.saturnBought == true)
            {
                gotItem.text = "Saturn   +1500$";
                gameManager.editCurrency(+1500);
            }
        }
        else if (choosePlanet == 2)
        {
            if (buyPlanet.marsBought == false)
            {
                PlayerPrefs.SetInt("marsBought", 1);
                gotItem.text = "Mars";
            }
            else if (buyPlanet.marsBought == true)
            {
                gotItem.text = "Mars  +1500$";
                gameManager.editCurrency(+1500);
            }
        }
        else if (choosePlanet == 3)
        {
            if (buyPlanet.neptuneBought == false)
            {
                PlayerPrefs.SetInt("neptuneBought", 1);
                gotItem.text = "Neptune";
            }
            else if (buyPlanet.neptuneBought == true)
            {
                gotItem.text = "Neptune  +1500$";
                gameManager.editCurrency(+1500);
            }
        }
        else if (choosePlanet == 4)
        {
            if (buyPlanet.jupiterBought == false)
            {
                PlayerPrefs.SetInt("jupiterBought", 1);
                gotItem.text = "Jupiter";
            }
            else if (buyPlanet.jupiterBought == true)
            {
                gotItem.text = "Jupiter  +1500$";
                gameManager.editCurrency(+1500);
            }
        }
        else if (choosePlanet == 5)
        {
            if (buyPlanet.mercuryBought == false)
            {
                PlayerPrefs.SetInt("mercuryBought", 1);
                gotItem.text = "Mercury";
            }
            else if (buyPlanet.mercuryBought == true)
            {
                gotItem.text = "Mercury  +1500$";
                gameManager.editCurrency(+1500);
            }
        }
        else if (choosePlanet == 6)
        {
            if (buyPlanet.venusBought == false)
            {
                PlayerPrefs.SetInt("venusBought", 1);
                gotItem.text = "Venus";
            }
            else if (buyPlanet.venusBought == true)
            {
                gotItem.text = "Venus  +1500$";
                gameManager.editCurrency(+1500);
            }
        }
        else if (choosePlanet == 7)
        {
            if (buyPlanet.uranusBought == false)
            {
                PlayerPrefs.SetInt("uranusBought", 1);
                gotItem.text = "Uranus";
            }
            else if (buyPlanet.uranusBought == true)
            {
                gotItem.text = "Uranus  +1500$";
                gameManager.editCurrency(+1500);
            }
        }
    }


}
