using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollisionController : MonoBehaviour {
    public float maxHealth;
    public float currentHealth;

    public float scoreCurrent;
    public float maxScore;

    public int coinValue;

    public Image healthBar;
    public Text scoreText;

//	// Use this for initialization
	void Start ()
    {
        currentHealth = maxHealth;
    }
	
//	// Update is called once per frame
	void Update ()
    {
        healthBar.fillAmount = (float)currentHealth / 100;
        scoreText.text = "Score: " + scoreCurrent.ToString();
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if(currentHealth <= 0)
        {
            //Die
        }

        //add score counter here
    }

    void OnTriggerEnter(Collider collision)// this runs all of the collision scripts however try to optomize this script more.
    {
        if(collision.GetComponent<Collider>().gameObject.tag == "Rock")
        {
            currentHealth = currentHealth - 5;//this should be a public int to have adjustable damage
        }

        if (collision.GetComponent<Collider>().gameObject.tag == "Coin")
        {
            scoreCurrent += coinValue;// this will increment the current score by the value of the given object
        }

        if(collision.GetComponent<Collider>().gameObject.tag == "Wave")
        {
            currentHealth = currentHealth - 10; //this should be a public int to have adjustable damage
        }

        if(collision.GetComponent<Collider>().gameObject.tag == "Siren")
        {
            currentHealth = currentHealth - 10;
        }

        if(collision.GetComponent<Collider>().gameObject.tag == "SirenAura")
        {
            currentHealth = currentHealth - 10;
        }
    }
}
