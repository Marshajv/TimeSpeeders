using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WeaponChest : MonoBehaviour {

	//public GameObject chest;
	private float obstacleSpeed;
	public float minSpeed;
	public float maxSpeed;
	public Animator weaponChest;

	// Use this for initialization
	void Start()
	{
		obstacleSpeed = (Random.Range(minSpeed, maxSpeed));
	}

	//public void SetTrigger

	void Update()
	{
		Movement();
	}

	public void Movement()
	{
		transform.Translate(Vector3.forward * obstacleSpeed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider collision)
	{
		if (collision.GetComponent<Collider>().gameObject.tag == "Player") {
			print ("hit");
			GetComponent<Animator>().Play("weaponChest");
			//GetComponent<Animation> ().Play();
			GetComponent<AudioSource>().Play();
			//Destroy (this.gameObject, 11);
			Respawn ();
		}
	}

	void Respawn()
	{
		transform.position = new Vector3(Random.Range(-6, 6), 0.68f, Random.Range(-50, -35));
	}
			
}
