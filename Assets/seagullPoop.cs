using UnityEngine;
using System.Collections;

public class seagullPoop : MonoBehaviour {
    public float fireFreq;
    public float lastShot;

    public GameObject birdPoo;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastShot + fireFreq)
        {
            Fire();
        }
    }

    void Fire()
    {
        lastShot = Time.time;
        Instantiate(birdPoo, transform.position, transform.rotation);
    }
}
