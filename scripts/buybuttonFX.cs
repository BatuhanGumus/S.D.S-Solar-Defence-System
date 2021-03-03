using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buybuttonFX : MonoBehaviour {

    private int currencyValue;
    public int criticnum;

    AudioSource audio;
    public AudioClip under;
    public AudioClip enough;
    
    // Use this for initialization
    void Start () {
        audio = gameObject.GetComponent<AudioSource>();
       
    }
	
	// Update is called once per frame
	void Update () {
     

    }

    public void buying()
    {
       
            audio.clip = enough;
            audio.Play();
      
        
    }
    
    public void equip()
    {
        audio.clip = enough;
        audio.Play();
    }

    public void cantBuy()
    {
        audio.clip = under;
        audio.Play();
    }
}
