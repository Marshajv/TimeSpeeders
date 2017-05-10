using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LeviathanBehavior : MonoBehaviour {
    private float leviCurHealth;
    public float leviMaxHealth;

    public float playerHit;
    public GameObject leviDeath;

    bool isDead = false;

    void Start()
    {
        leviCurHealth = leviMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyDead();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Collider>().gameObject.tag == "Bullet")
        {
            leviCurHealth = leviCurHealth - playerHit;

        }
    }
    void EnemyDead()
    {
        if (leviCurHealth <= 0)
        {
            //  Destroy(gameObject);
            //  isDead = true;
            leviCurHealth = leviMaxHealth;
            this.gameObject.GetComponent<Animator>().Play("LeviDeath");
            StartCoroutine(Next());
         //   SceneManager.LoadScene("Menu");

        }
    }

    IEnumerator Next()
    {
        yield return new WaitForSeconds(5);
            SceneManager.LoadScene("WinScene");
    }
}