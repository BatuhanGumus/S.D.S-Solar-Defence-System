using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class projectile : MonoBehaviour {
	public GameManager gameManager;
	private Rigidbody2D rb;
    private Vector3 defenceBeforeHit;
    private Vector3 defenceAfterHit;
    private SpriteRenderer sr;
	private bool restart = false;
	public float projectileSpeed;
	private float projectileSwing;
	private bool firstThrowControl = false;
	private float time = 0;
	private float randTime;
	private TrailRenderer tr;
	public int maxSpeed = -3;
	public int minSpeed = -1;
	public GameObject explosionGreen;
    public GameObject explosionRed;
    public GameObject explosionBlue;
    public GameObject explosionGreenUfo;
    public GameObject explosionRedUfo;
    public GameObject smallFire;
    public GameObject biglFire;
    public defenceMovement defenceMovement;
    new Vector3 beforeVelotity;
    private float addVelocity;
    public int damageMulti;
    public bool checkColor = false;
    public int damagemultivalue;
    public PurpleProjEffect PurpleProjEffect;
    public defenceUlt defenceUlt;
    public CapsuleCollider2D earthcol;
    public float colSizeY;

    AudioSource audio;
    public AudioClip bounce1;
    public AudioClip bounce2;
    public AudioClip bounce3;
    public AudioClip bounce4;

    public AudioClip purpleBounce1;

    public AudioClip explosion1;
    public AudioClip explosion2;
    public AudioClip explosion3;
    public AudioClip explosion4;

    public AudioClip shieldExplosion1;
    public AudioClip shieldExplosion2;
    public AudioClip shieldExplosion3;
    public AudioClip shieldExplosion4;

    public AudioClip ufoExplosionGreen;
    public AudioClip ufoExplosionRed;


    // Use this for initialization
    void Start () {
		rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        tr = GetComponent<TrailRenderer>();
        tr.startColor = new Color(0f, 0f, 0f, 0f);
        tr.endColor = new Color(0f, 0f, 0f, 0f);
        sr.color = new Color(0f, 0f, 0f, 0f);

        audio = gameObject.GetComponent<AudioSource>();

        earthcol = GameObject.Find("earth").GetComponent<CapsuleCollider2D>();
        scaleCol();


        //Throw();
    }
	// Update is called once per frame
	void Update () {
        beforeVelotity = rb.velocity;
        outScreenControl ();
        defenceBeforeHit = GameObject.Find("defence").transform.position;

        /*if (gameManager.gameEndLose == true || gameManager.gameEndWin == true){
			Destroy(this.gameObject);
		}*/

        if (gameManager.gameStart == false){
			rb.velocity = new Vector2(0, 0);
			transform.position = new Vector2 (0, 4);
		}else {
			if (firstThrowControl == false){
				Throw();
				firstThrowControl = true;
			}
		}
		
	}
	void FixedUpdate()
	{
		if(restart == true)
        {

            tr.emitting = false;
            tr.enabled = false;
			tr.Clear();
            tr.startColor = new Color(0f, 0f, 0f, 0f);
            tr.endColor = new Color(0f, 0f, 0f, 0f);
            sr.color = new Color(0f, 0f, 0f, 0f);



            if (gameManager.gameEndLose == false)
            {
                randTime = Random.Range(0, 1.5f);
                time += Time.deltaTime;
                if (time >= 1.5f)
                {
                    rb.velocity = new Vector2(0, 0);
                    transform.position = new Vector2(0, 4);
                    Throw();
                    time = 0;
                    restart = false;
                }
            }
			
			
		}
	}

	void OnTriggerEnter2D (Collider2D collidor) {

		if (collidor.gameObject.tag == "Earth") {
            

            int randomSound = Random.Range(1, 5);

            if (damageMulti == 19 || damageMulti == 18)
            {

                damagemultivalue = 2;
                Instantiate(explosionRed, gameObject.transform.position, Quaternion.identity);

            }
            else if (damageMulti == 20)
            {
                damagemultivalue = 0;

            }
            else
            {
                damagemultivalue = 1;
                Instantiate(explosionGreen, gameObject.transform.position, Quaternion.identity);

            }
            gameManager.projHit(damagemultivalue);

            if (gameManager.finalDamage < 0)
            {
                if (damageMulti == 19 || damageMulti == 18)
                {
                    Instantiate(biglFire, gameObject.transform.position, Quaternion.identity);
                }
                else if (damageMulti == 20)
                {

                }
                else
                {
                    Instantiate(smallFire, gameObject.transform.position, Quaternion.identity);
                }
            }


            if (damageMulti == 19 || damageMulti == 18)
            {
                    if (gameManager.finalDamage < 0)
                    {
                        if (randomSound == 1)
                        {
                            audio.clip = explosion1;
                        }
                        else if (randomSound == 2)
                        {
                            audio.clip = explosion2;
                        }
                        else if (randomSound == 3)
                        {
                            audio.clip = explosion3;
                        }
                        else if (randomSound == 4)
                        {
                            audio.clip = explosion4;
                        }
                    }
                    else
                    {
                        if (randomSound == 1)
                        {
                            audio.clip = shieldExplosion1;
                        }
                        else if (randomSound == 2)
                        {
                            audio.clip = shieldExplosion2;
                        }
                        else if (randomSound == 3)
                        {
                            audio.clip = shieldExplosion3;
                        }
                        else if (randomSound == 4)
                        {
                            audio.clip = shieldExplosion4;
                        }

                    }

                audio.volume = 0.20f;
                audio.Play();


            }
            else if (damageMulti == 20)
             {
                
             }
              else
              {

                if (gameManager.finalDamage < 0)
                    {
                        if (randomSound == 1)
                        {
                            audio.clip = explosion1;
                        }
                        else if (randomSound == 2)
                        {
                            audio.clip = explosion2;
                        }
                        else if (randomSound == 3)
                        {
                            audio.clip = explosion3;
                        }
                        else if (randomSound == 4)
                        {
                            audio.clip = explosion4;
                        }
                    }
                    else
                    {
                        if (randomSound == 1)
                        {
                            audio.clip = shieldExplosion1;
                        }
                        else if (randomSound == 2)
                        {
                            audio.clip = shieldExplosion2;
                        }
                        else if (randomSound == 3)
                        {
                            audio.clip = shieldExplosion3;
                        }
                        else if (randomSound == 4)
                        {
                            audio.clip = shieldExplosion4;
                        }

                    
                    }

                audio.volume = 0.20f;
                audio.Play();


              }

           
            checkColor = false;

            PlayerPrefs.SetInt("gotHitTimes", PlayerPrefs.GetInt("gotHitTimes") + 1);

            restart = true;

           
        }
		if (collidor.gameObject.tag == "ufo"){

            if (damageMulti == 19 || damageMulti == 18)
            {
                audio.clip = ufoExplosionRed;
                damagemultivalue = 2;
                Instantiate(explosionRedUfo, gameObject.transform.position, Quaternion.identity);
            }
            else if (damageMulti == 20)
            {
                damagemultivalue = 0;
            }
            else
            {
                audio.clip = ufoExplosionGreen;
                
                   damagemultivalue = 1;
                Instantiate(explosionGreenUfo, gameObject.transform.position, Quaternion.identity);
            }
            audio.volume = 0.10f;
            audio.Play();

            gameManager.projHitUfo(damagemultivalue);
            
            checkColor = false;

            PlayerPrefs.SetInt("hitUfoTimes", PlayerPrefs.GetInt("hitUfoTimes") + 1);

            restart = true;

            
        }

	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "defence")
        {


            if (damageMulti == 20)
            {
                Instantiate(explosionBlue, gameObject.transform.position, Quaternion.identity);

                PurpleProjEffect.stayOnTimer = 0;
                PurpleProjEffect.active = true;
                restart = true;

                if (defenceUlt.stayOn == true)
                {
                    if (defenceUlt.stayOnTimer >= 5)
                    {
                        defenceUlt.stayOnTimer -= 5;
                    }
                    else
                    {
                        defenceUlt.stayOnTimer = 0;
                    }
                }
            }
            else
            {
                PlayerPrefs.SetInt("reflectedTimes", PlayerPrefs.GetInt("reflectedTimes") + 1);
            }
            int randomSound = Random.Range(1, 5);

            if (damageMulti == 19 || damageMulti == 18)
            {
                if (randomSound == 1)
                {
                    audio.clip = bounce1;
                }
                else if (randomSound == 2)
                {
                    audio.clip = bounce2;
                }
                else if (randomSound == 3)
                {
                    audio.clip = bounce3;
                }
                else if (randomSound == 4)
                {
                    audio.clip = bounce4;
                }
                
            }
            else if (damageMulti == 20)
            {
                audio.clip = purpleBounce1;
                tr.Clear();
                tr.emitting = false;
                tr.enabled = false;
                transform.position = new Vector2(50, 50);

                
            }
            else
            {
                if (randomSound == 1)
                {
                    audio.clip = bounce1;
                }
                else if (randomSound == 2)
                {
                    audio.clip = bounce2;
                }
                else if (randomSound == 3)
                {
                    audio.clip = bounce3;
                }
                else if (randomSound == 4)
                {
                    audio.clip = bounce4;
                }
            }



            audio.volume = 0.35f;
            audio.Play();
            Vector3 afterVelosity = rb.velocity;
            defenceAfterHit = GameObject.Find("defence").transform.position;
            print(defenceBeforeHit);
            print(defenceAfterHit);
            // Vector3 affectX = (defenceBeforeHit.x - defenceAfterHit.x , 0);
            Vector3 curve = new Vector3(defenceAfterHit.x - defenceBeforeHit.x, 0 , 0);
            print(curve);

            if (afterVelosity.y >= 0 && afterVelosity.x >= 0)
            {
                rb.velocity = new Vector3((Mathf.Abs(beforeVelotity.x) * 1.2f) + afterVelosity.x / 10, (Mathf.Abs(beforeVelotity.y) * 1.2f) + afterVelosity.y / 10, 0);
            }
            else if (afterVelosity.y >= 0 && afterVelosity.x < 0)
            {
                rb.velocity = new Vector3((Mathf.Abs(beforeVelotity.x) * -1.2f) + afterVelosity.x / 10, (Mathf.Abs(beforeVelotity.y) * 1.2f) + afterVelosity.y / 10, 0);
            }
            else if (afterVelosity.y < 0 && afterVelosity.x > 0)
            {
                rb.velocity = new Vector3(afterVelosity.x, (Mathf.Abs(beforeVelotity.y) * -1.2f) + afterVelosity.y / 10, 0);
            }
            else if (afterVelosity.y < 0 && afterVelosity.x <= 0)
            {
                rb.velocity = new Vector3(afterVelosity.x, (Mathf.Abs(beforeVelotity.y) * -1.2f) + afterVelosity.y / 10, 0);
            }

            rb.AddForce(curve * 40000000);

        }
    }

	public void Throw (){
       if (gameManager.gameEndLose == false) 
       { 
            projectileSpeed = Random.Range (maxSpeed, minSpeed);
			projectileSwing = Random.Range (-1.1f, 1.1f);
       
            rb.AddForce (new Vector2 (projectileSwing * 100000, 0), ForceMode2D.Impulse);
			    rb.AddForce (new Vector2 (0, projectileSpeed * 50000), ForceMode2D.Impulse);

            damageMulti = Random.Range(1, 21);
            //damageMulti = 20;

            tr.emitting = true;
            tr.enabled = true;

            if (damageMulti == 19 || damageMulti == 18)
            {
                tr.startColor = new Color(1f, 0, 0, 1f);
                tr.endColor = new Color(1f, 0f, 0f, 0f);
                sr.color = new Color(1f, 0f, 0f);

            }
            else if (damageMulti == 20){
                tr.startColor = new Color(0, 0.8f, 1f, 1f);
                tr.endColor = new Color(0f, 0.8f, 1f, 0f);
                sr.color = new Color(0f, 0.8f, 1f);
            }
            else
            {
                tr.startColor = new Color(0f, 1, 0f, 1f);
                tr.endColor = new Color(0f, 1, 0f, 0f);
                sr.color = new Color(0f, 1f, 0f);
            }

       }
    }

	public void outScreenControl () {
		if(transform.localPosition.y <= -5.2){
			restart = true;
		}
		if(transform.localPosition.y >= 6){
			restart = true;
		}
		if(transform.localPosition.x >= 4){
			restart = true;
		}
		if(transform.localPosition.x <= -4){
			restart = true;
		}

	}

    public void scaleCol()
    {
        colSizeY = Random.RandomRange(4.5f, 6.3f);
        earthcol.size = new Vector2(7.2f, colSizeY);

        Invoke("scaleCol", 3);
    }

}

		




 

