using UnityEngine;
using System.Collections;

public class LeviMovement : MonoBehaviour {
    public float levSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Mathf.PingPong((Time.time*levSpeed), 5),transform.position.y, transform.position.z);
    }
}
