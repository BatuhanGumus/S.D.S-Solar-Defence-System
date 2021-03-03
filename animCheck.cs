using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animCheck : MonoBehaviour {

    Animator animatorMilkyWay;

    Animator animatorSDS;

    Animator animatorRecord;

    Animator animatorPlayButton;
    Animator animatorPlayText;

    Animator animatorMenuButton;
    Animator animatorMenuText;

    public GameObject milkyway;

    public Text SDS;

    public Text record;

    public Button playButton;
    public Text playText;

    public Button menuButton;
    public Text menuText;

    public static bool firstbool = true;

    // Use this for initialization
    void Start () {
        animatorMilkyWay = milkyway.GetComponent<Animator>();

        animatorSDS = SDS.GetComponent<Animator>();

        animatorRecord = record.GetComponent<Animator>();

        animatorPlayButton = playButton.GetComponent<Animator>();
        animatorPlayText = playText.GetComponent<Animator>();

        animatorMenuButton = menuButton.GetComponent<Animator>();
        animatorMenuText = menuText.GetComponent<Animator>();

        animatorMilkyWay.SetBool("first", firstbool);

        animatorSDS.SetBool("first", firstbool);

        animatorRecord.SetBool("first", firstbool);

        animatorPlayButton.SetBool("first", firstbool);
        animatorPlayText.SetBool("first", firstbool);

        animatorMenuButton.SetBool("first", firstbool);
        animatorMenuText.SetBool("first", firstbool);


        Invoke("firstdone", 0.1f);

    }
	

    void firstdone()
    {
        firstbool = false;
    }
}
