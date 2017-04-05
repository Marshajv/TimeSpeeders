using UnityEngine;
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
    
    public GameObject waveShot;
    public GameObject whirlPool;

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
            Shooting();
        }
        //EnemyShoot();
        transform.Rotate((new Vector3(0, 0, 1) * whirlRotSpeed) * Time.deltaTime);//rotates around the x axis counterclockwise
    }

    public void EnemyDead()
    {
        if (waveCurHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<Collider>().gameObject.tag == "Bullet")
        {
            waveCurHealth = waveCurHealth - 10;//set this as a float
            Debug.Log("ouchies");
        }
    }
    public void Shooting()
    {
        GameObject newShot = Instantiate(waveShot, shotPosition.transform.position,Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
        newShot.GetComponent<Rigidbody>().AddForce(newShot.transform.forward * wavOutputSpd);
        Destroy(newShot, destroyTime);
    }

    IEnumerator ShotRate()
    {
        yield return new WaitForSeconds(waitWave);
    }
}
