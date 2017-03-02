//jadeM
//3-1-17

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaveShooter : MonoBehaviour {
    public float waveRot;
    public float waveBs;
    [Tooltip("this is the speed of the waves output.")]

    public GameObject waveBase;
    public GameObject waveBullets;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter(Collider other)
    {
        
    
    }

    //IEnumerator Attack()
    //{
    //GameObject waveBase = Instantiate(waveBullets, waveBase.position, Quaternion.identity);
    //}
}
