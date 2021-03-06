﻿using UnityEngine;
using System.Collections;

public class SirenBehavior : MonoBehaviour {
    private float sirenCurHealth;
    public float sirenMaxHealth;
    public float playerHit;

    bool isDead = false;

    void Start () {
        sirenCurHealth = sirenMaxHealth;
    }
	
	// Update is called once per frame
	void Update () {
        EnemyDead();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Collider>().gameObject.tag == "Bullet")
        {
            sirenCurHealth = sirenCurHealth - playerHit;

        }
    }
     void EnemyDead()
    {
        if (sirenCurHealth <= 0)
        {
            //  Destroy(gameObject);
            //  isDead = true;
            Respawn();
            sirenCurHealth = sirenMaxHealth;
        }
    }

    void Respawn()
    {
        transform.position = new Vector3(Random.Range(-6, 6), 0.68f, Random.Range(-50, -35));
    }
}
