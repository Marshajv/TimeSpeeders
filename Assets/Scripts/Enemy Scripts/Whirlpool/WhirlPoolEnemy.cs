﻿using UnityEngine;
using System.Collections;
//this is the auto shooting rotaing enemy AI script it basically rotates the enemy and then outputs the shot at the point rotation.
public class WhirlPoolEnemy : MonoBehaviour
{
    public float waveCurHealth;
    public float waveMaxHealth;
    public float whirlRotSpeed;
    public float waitWave;
    public float destroyTime;
    public float wavOutputSpd;

    public float playerDist;
    public float attckDist;

    public Transform player;
    public Transform shotPosition;
    
    public Rigidbody waveShot;
    public GameObject whirlPool;

    bool fired = false;
    void Start()
    {
        waveCurHealth = waveMaxHealth;
    }

    void Update()
    {
        EnemyDead();
        playerDist = Vector3.Distance(player.position, transform.position);
        if (playerDist< attckDist)
        {
            //Shooting();
            if(!fired)
            StartCoroutine(ShotRate());
        }
        //EnemyShoot();
        transform.Rotate((new Vector3(0, 0, 1) * whirlRotSpeed) * Time.deltaTime);//rotates around the x axis counterclockwise
    }

    public void EnemyDead()
    {
        if (waveCurHealth <= 0)
        {
            //Destroy(gameObject);
            Respawn();
            waveCurHealth = waveMaxHealth;
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Collider>().gameObject.tag == "Bullet")
        {
            waveCurHealth = waveCurHealth - 10;//set this as a float
            //Debug.Log("ouchies");
        }
    }
    public void Shooting()
    {

        Rigidbody clone;
        clone = Instantiate(waveShot, transform.position, transform.rotation) as Rigidbody;
        clone.velocity = transform.TransformDirection(Vector3.left * wavOutputSpd);
    }

    IEnumerator ShotRate()
    {
        fired = true;
        yield return new WaitForSeconds(waitWave);
        Shooting();
        fired = false;
    }

    void Respawn()
    {
        transform.position = new Vector3(Random.Range(-6, 6), 0.68f, Random.Range(-50, -35));
    }
}
