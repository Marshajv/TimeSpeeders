using UnityEngine;
using System.Collections;
//this script is set on the specific game object to be pooled however this is not the most efficent way
public class Pickupables : MonoBehaviour {
	public GameObject coin;
	public float coinCounter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
//	void OnTriggerEnter(Collider other){//I need a way of picking the tag and triggering other events
//		if (collision.gameObject.tag == "Coin") {
//			DestroyObject (Collision.gameobject);
//			coinCounter++;
//		}
//	}
}