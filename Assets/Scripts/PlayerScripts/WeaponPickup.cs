using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WeaponPickup : MonoBehaviour {

	public float JavelinshotSpeed;
	public float JavelinbulletSpeed;
	public float JavelindestroyTime;
	public float JavelinwaitBullet;

	public GameObject JavelinshotOutput;
	public GameObject Javelinbullet;
	//public Image Javelinicon;

	public float BowshotSpeed;
	public float BowbulletSpeed;
	public float BowdestroyTime;
	public float BowwaitBullet;

	public GameObject BowshotOutput;
	public GameObject Bowbullet;
	//public Image Bowicon;

	ShootingScript shooting;

	void Start()
	{
		shooting = GameObject.FindGameObjectWithTag ("ShotOutput").GetComponent<ShootingScript> ();
	}
	void OnTriggerEnter2D()
	{
		int check = Random.Range (0, 1);
		print ("check = " + check);
		if (check == 0)
		{
			shooting.UpdateWeapon (JavelinshotSpeed, JavelinbulletSpeed, JavelinwaitBullet, JavelinshotOutput, Javelinbullet); //Javelinicon
		}

		if (check == 1)
		{
			shooting.UpdateWeapon (BowshotSpeed, BowbulletSpeed, BowwaitBullet, BowshotOutput, Bowbullet); //Bowicon
		}

		Destroy (this.gameObject);
	}
}
