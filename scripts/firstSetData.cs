using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstSetData : MonoBehaviour {
    public bool APK = false;
	// Use this for initialization
	void Start () {
        if (APK == false)
        {
            int firstvalue = PlayerPrefs.GetInt("first");
            if (firstvalue == 0)
            {
                PlayerPrefs.SetInt("currentDefenceLenght", 1);
                PlayerPrefs.SetInt("currentShieldLife", 2);
                PlayerPrefs.SetInt("currentShieldRegen", 1);
                PlayerPrefs.SetInt("defenceExtendExpense", 300);
                PlayerPrefs.SetInt("shieldLifeExpense", 100);
                PlayerPrefs.SetInt("shieldRegenExpense", 300);
                PlayerPrefs.SetFloat("defenceHight", 0.8f);
                PlayerPrefs.SetFloat("volume", 0.2f);

                PlayerPrefs.SetInt("first", 1);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
