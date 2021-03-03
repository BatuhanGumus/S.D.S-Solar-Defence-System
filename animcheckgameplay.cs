using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animcheckgameplay : MonoBehaviour {
    public bool gameBegin = false;
    public bool gameEnd = false;

    Animator animatorDroppedText;
    public Text droppedText;

    Animator animatortimerText;
    public Text timerText;

    Animator animatorpausebutton;
    public Button pausebutton;

    Animator animatorpauseText;
    public Text pauseText;

    Animator animatorpanel;
    public Image panel;

    // Use this for initialization
    void Start () {
        animatorDroppedText = droppedText.GetComponent<Animator>();
        animatortimerText = timerText.GetComponent<Animator>();
        animatorpausebutton = pausebutton.GetComponent<Animator>();
        animatorpauseText = pauseText.GetComponent<Animator>();

        animatorpanel = panel.GetComponent<Animator>();
    }
	
	// Update is called once per frame  
	void Update () {
        animatorDroppedText.SetBool("gameBegin", gameBegin);
        animatortimerText.SetBool("gameBegin", gameBegin);
        animatorpausebutton.SetBool("gameBegin", gameBegin);
        animatorpauseText.SetBool("gameBegin", gameBegin);

        animatorpanel.SetBool("gameEnd", gameEnd);
    }
}
