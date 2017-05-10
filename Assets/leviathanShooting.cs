using UnityEngine;
using System.Collections;

public class leviathanShooting : MonoBehaviour {
    public float fireFreq;
    public float lastShot;

    public GameObject fireBall;

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
        Instantiate(fireBall, transform.position, transform.rotation);
    }
}
