using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class defenceMovement : MonoBehaviour {
    public bool testing = false;
    public GameManager gameManager;
    public pause pause;
    public ultPause ultPause;
    public float touchX;
    public float touchY;
    public float currentX;
    public float currentY;
    public float differenceX;
    public float differenceY;
    public GameObject defence;
    public Rigidbody2D rb;
    public float defencePosX;
    public float defencePosY;
    public bool onUlt = false;
    public float hightValue;


    // Use this for initialization
    void Start () {

        hightValue = PlayerPrefs.GetFloat("defenceHight");

        rb = GetComponent<Rigidbody2D>();
        gameManager.getDefenceLength();


	transform.localScale = new Vector3(gameManager.getDefenceScale, transform.localScale.y, transform.localScale.z);
	}
	
	// Update is called once per frame
	void Update () {


        if (testing == true)
        {
            if (gameManager.gameStart == true)
            {
                if (pause.timeStopped == false && ultPause.timeStopped == false)
                {
                    if (gameManager.gameEndLose == false)
                    {
                        if (Input.mousePosition.y / Screen.height * 10 - 5.0f < 2f)
                        {




                            defencePosX = Mathf.Clamp(Input.mousePosition.x / Screen.width * 5.6f - 2.8f, -2.8f, 2.8f);
                            defencePosY = Mathf.Clamp(Input.mousePosition.y / Screen.height * 10 - 5f + hightValue, -3.3f, -0f);



                            rb.MovePosition(new Vector3(defencePosX, defencePosY, 0));

                        }
                    }
                }
            }
        }
       
        if (testing == false)
        {
            if (gameManager.gameStart == true)
            {
                if (pause.timeStopped == false && ultPause.timeStopped == false)
                {
                    if (gameManager.gameEndLose == false)
                    {
                        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
                        {

                            Vector2 touchPosition = Input.GetTouch(0).position;

                            defencePosX = Mathf.Clamp(touchPosition.x / Screen.width * 5.6f - 2.8f, -2.8f, 2.8f);
                            defencePosY = Mathf.Clamp(touchPosition.y / Screen.height * 10 - 5f + hightValue, -3.3f, -0f);

                            if (touchPosition.y / Screen.height * 10 - 4f < 4f)
                            {
                                rb.MovePosition(new Vector3(defencePosX, defencePosY, 0));
                            }
                        }else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
                        {
                            Vector2 touchPosition = Input.GetTouch(0).position;

                            defencePosX = Mathf.Clamp(touchPosition.x / Screen.width * 5.6f - 2.8f, -2.8f, 2.8f);
                            defencePosY = Mathf.Clamp(touchPosition.y / Screen.height * 10 - 5f + hightValue, -3.3f, -0f);

                            if (touchPosition.y / Screen.height * 10 - 4f < 4f)
                            {
                               transform.position = new Vector3(defencePosX, defencePosY, 0);
                            }
                        }
                    }
                }
            }
        }
        


    }

 


}
