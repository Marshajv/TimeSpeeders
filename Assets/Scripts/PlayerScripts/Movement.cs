using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public float constSpeed;
    public float speed;
    public float rotationSpeed;

    public float clampPositionYMin;
    public float clampPositionYMax;
    public float clampPositionZMin;
    public float clampPositionZMax;

    public float jumpForce;
    public float jumpTime;
    public bool isGrounded;

    public Rigidbody myRigidbody;
	void Start () {
	
	}
	void Update () {
        ConstantMovement();
		Jump();
	    float translationV=Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float translationH = Input.GetAxis("Horizontal") * -speed * Time.deltaTime;
        //  float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Translate(translationH, translationV, 0);
      //  transform.Rotate(0, 0, rotation);

        transform.position = new Vector3((Mathf.Clamp(transform.position.x, clampPositionYMin, clampPositionYMax)), transform.position.y, (Mathf.Clamp(transform.position.z, clampPositionZMin, clampPositionZMax)));
	}

    void ConstantMovement(){
        //print(myRigidbody.velocity.x);
        myRigidbody.velocity = new Vector3(0, myRigidbody.velocity.x, constSpeed);
    }

	public void Jump(){
		if (Input.GetButtonDown ("Jump") && isGrounded==true) {
            isGrounded = false;
            Debug.Log ("jumps");
            myRigidbody.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            //transform.Translate (Vector3.up*jumpForce*Time.deltaTime);
			//Vector3 up = transform.TransformDirection (Vector3.up);
			//myRigidbody.AddForce (up * 5, ForceMode.Impulse);
		//} else if (isGrounded == false) {
			StartCoroutine(JumpWait ());
		}			
	}

	IEnumerator JumpWait(){
		yield return new WaitForSeconds(jumpTime);
        isGrounded = true;
    }
}

