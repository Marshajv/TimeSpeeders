﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public float constSpeed;
    public float speed;
    public float rotationSpeed;
    public float fireRate;

    private float nextFire;

    public Transform shotSpawn;

    public float clampPositionYMin;
    public float clampPositionYMax;
    public float clampPositionZMin;
    public float clampPositionZMax;

    public float shotSpeed;
    public float jumpForce;
    public float jumpTime;
    public bool isGrounded;
    bool inverted;

    private GameObject bullet;

    public Rigidbody myRigidbody;

    void Start() {

    }
    void Update() {
        //ConstantMovement();
        regMovement();
        Jump();
        Shooting();
    }
    public void regMovement() {
        float translationH = Input.GetAxis("Horizontal") * -speed * Time.deltaTime;
        transform.Translate(translationH, 0, 0);

        transform.position = new Vector3((Mathf.Clamp(transform.position.x, clampPositionYMin, clampPositionYMax)), transform.position.y, (Mathf.Clamp(transform.position.z, clampPositionZMin, clampPositionZMax)));
    }

	public void Jump(){
		if (Input.GetButtonDown ("Jump") && isGrounded==true) {
            isGrounded = false;
            Debug.Log ("jumps");
            myRigidbody.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
			StartCoroutine(JumpWait ());
		}			
	}
	public void Shooting(){
		if (Input.GetButtonDown ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
		}
	}

	IEnumerator JumpWait(){
		yield return new WaitForSeconds(jumpTime);
        isGrounded = true;
    }
}

