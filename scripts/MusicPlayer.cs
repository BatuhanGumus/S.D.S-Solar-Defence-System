using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class MusicPlayer : MonoBehaviour {
    static MusicPlayer instance = null;
    public Scene scene;
    AudioSource audio;

    public AudioClip mainMenuClip;
    public AudioClip gameplayCip;

    public bool changemusic = true;
    public bool dontchangemusic = false;

    void Start() {
       


        audio = gameObject.GetComponent<AudioSource>();
        
        


        if (instance != null && instance != this) {
            Destroy(gameObject);
        } else {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }

    }

    void Update()
    {
        
        float volumeValue = PlayerPrefs.GetFloat("volume");
        audio.volume = volumeValue;

        
    }

    void OnLevelWasLoaded()
    {
        scene = SceneManager.GetActiveScene();

        if (scene.name == "gameplay")
        {
            if (!dontchangemusic)
            {
                audio.clip = gameplayCip;
                audio.Play();
                changemusic = true;
                dontchangemusic = true;
            }
        }
        

        if (scene.name == "start menu")
        {
            if (changemusic)
            {
                audio.clip = mainMenuClip;
                audio.Play();
                changemusic = false;
                dontchangemusic = false;
            }
            
        }
        
    }



}
