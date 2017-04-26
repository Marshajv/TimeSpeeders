using UnityEngine;
using System.Collections;

public class SeagullBeahvior : MonoBehaviour {
    private float birbCurHealth;
    public float birbMaxHealth;

    public float playerHit;

    bool isDead = false;

    void Start()
    {
        birbCurHealth = birbMaxHealth;
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
            birbCurHealth = birbCurHealth - playerHit;

        }
    }
    void EnemyDead()
    {
        if (birbCurHealth <= 0)
        {
            //  Destroy(gameObject);
            //  isDead = true;
            Respawn();
            birbCurHealth = birbMaxHealth;
        }
    }

    void Respawn()
    {
        transform.position = new Vector3(Random.Range(-6,-7), 0.68f, Random.Range(-50, -21));
    }
}

