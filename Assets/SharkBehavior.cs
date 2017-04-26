using UnityEngine;
using System.Collections;

public class SharkBehavior : MonoBehaviour {
    private float sharkCurHealth;
    public float sharkMaxHealth;
    public float playerHit;

    bool isDead = false;

    // Use this for initialization
    void Start () {
        sharkCurHealth = sharkMaxHealth;
    }
	
	// Update is called once per frame
	void Update () {
        EnemyDead();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Collider>().gameObject.tag == "Bullet")
        {
            sharkCurHealth = sharkCurHealth - playerHit;

        }
    }

    void EnemyDead()
    {
        if (sharkCurHealth <= 0)
        {
            //  Destroy(gameObject);
            // isDead = true;
            Respawn();
            sharkCurHealth = sharkMaxHealth;
        }
    }

    void Respawn()
    {
        transform.position = new Vector3(Random.Range(-6, 6), 0.68f, Random.Range(-50, -35));
    }
}
