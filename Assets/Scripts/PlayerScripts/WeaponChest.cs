using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WeaponChest : MonoBehaviour {

	//public GameObject chest;

	// Use this for initialization

	void OnTriggerEnter(Collider collision)
	{
		if(collision.GetComponent<Collider>().gameObject.tag == "Player")
		{
			print ("hit");
			GetComponent<AudioSource>().Play();
			GetComponent<Animator>().Play("weaponChest");
			Destroy(this.gameObject, 2);
		}

	}
}
