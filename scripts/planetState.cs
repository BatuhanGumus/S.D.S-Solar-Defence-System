using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetState : MonoBehaviour {
	public GameManager gameManager;
    private int rotation;
	public SpriteRenderer sr;
	public Sprite mars;
	public Sprite earth;
	public Sprite saturn;
	public Sprite neptune;
	public Sprite jupiter;
	public Sprite mercury;
    public Sprite venus;
    public Sprite uranus;
    public Sprite moon;
    public Sprite europa;
    public Sprite mimas;
    public Sprite ganymade;

    // Use this for initialization
    void Start () {		
			changePlanet();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void changePlanet  (){
        sr = GetComponent<SpriteRenderer>();
        gameManager.getPlanet();

        //rotation = Random.Range(0, 361);

        if (gameManager.currentPlanet == "mars"){sr.sprite = mars;
            rotation = Random.Range(0, 361);
            sr.transform.Rotate(0, 0, rotation);
        }
		else if(gameManager.currentPlanet == "earth"){sr.sprite = earth;
            rotation = Random.Range(-40, 21);
            sr.transform.Rotate(0, 0, rotation);
        }
		else if(gameManager.currentPlanet == "saturn"){sr.sprite = saturn;
            sr.transform.Rotate(0, 0, 0);
        }
		else if(gameManager.currentPlanet == "neptune"){sr.sprite = neptune;
            rotation = Random.Range(0, 361);
            sr.transform.Rotate(0, 0, rotation);
        }
		else if(gameManager.currentPlanet == "jupiter"){sr.sprite = jupiter;
            rotation = Random.Range(0, 361);
            sr.transform.Rotate(0, 0, rotation);
        }
		else if(gameManager.currentPlanet == "mercury"){sr.sprite = mercury;
            rotation = Random.Range(0, 361);
            sr.transform.Rotate(0, 0, rotation);
        }
        else if (gameManager.currentPlanet == "venus") { sr.sprite = venus;
            rotation = Random.Range(0, 361);
            sr.transform.Rotate(0, 0, rotation);
        }
        else if (gameManager.currentPlanet == "uranus") { sr.sprite = uranus;
           
            sr.transform.Rotate(0, 0, 0);
        }
        else if (gameManager.currentPlanet == "moon") { sr.sprite = moon;
            rotation = Random.Range(0, 361);
            sr.transform.Rotate(0, 0, rotation);
        }
        else if (gameManager.currentPlanet == "europa")
        {
            rotation = Random.Range(0, 361);
            sr.sprite = europa;
            sr.transform.Rotate(0, 0, rotation);
        }
        else if (gameManager.currentPlanet == "mimas")
        {
            rotation = Random.Range(30, 120);
            sr.sprite = mimas;
            sr.transform.Rotate(0, 0, rotation);
        }
        else if (gameManager.currentPlanet == "ganymade")
        {
            sr.sprite = ganymade;
            rotation = Random.Range(0, 361);
            sr.transform.Rotate(0, 0, rotation);
        }
    }

    public void fakePlanet()
    {
        sr = GetComponent<SpriteRenderer>();
        gameManager.getPlanet();

        if (gameManager.currentPlanet == "mars") { sr.sprite = mars; }
        else if (gameManager.currentPlanet == "earth") { sr.sprite = earth; }
        else if (gameManager.currentPlanet == "saturn") { sr.sprite = saturn; }
        else if (gameManager.currentPlanet == "neptune") { sr.sprite = neptune; }
        else if (gameManager.currentPlanet == "jupiter") { sr.sprite = jupiter; }
        else if (gameManager.currentPlanet == "mercury") { sr.sprite = mercury; }
        else if (gameManager.currentPlanet == "venus") { sr.sprite = venus; }
        else if (gameManager.currentPlanet == "uranus") { sr.sprite = uranus; }
        else if (gameManager.currentPlanet == "moon") { sr.sprite = moon; }
        else if (gameManager.currentPlanet == "europa") { sr.sprite = europa; }
        else if (gameManager.currentPlanet == "mimas") { sr.sprite = mimas; }
        else if (gameManager.currentPlanet == "ganymade") { sr.sprite = ganymade; }
    }
}
