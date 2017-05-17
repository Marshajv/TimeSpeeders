using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootingScript : MonoBehaviour {
    public float shotSpeed;
	[Tooltip("This is the Shot output speed")]
    public float bulletSpeed;
    public float destroyTime;
	public float waitBullet;

    public GameObject shotOutput;
    public GameObject bullet;
	//public Image bulletIcon;

	private float shotSpeedOrg;
	private float bulletSpeedOrg;
	private float destroyTimeOrg;
	private float waitBulletOrg;

	private GameObject shotOutputOrg;
	private GameObject bulletOrg;
	//private Image bulletIconOrg;

	void Start ()
	{
		shotSpeedOrg = shotSpeed;
		bulletSpeedOrg = bulletSpeed;
		destroyTimeOrg = destroyTime;
		waitBulletOrg = waitBullet;
		shotOutputOrg = shotOutput;
		bulletOrg = bullet;
		//bulletIcon = bulletIconOrg;
	}

	public void UpdateWeapon(float speedP, float bulletSpeedP, float waitBulletP, GameObject shotOutputP, GameObject bulletP) //Image bulletIconP
	{
		shotSpeed = speedP;
		bulletSpeed = bulletSpeedP;
		waitBullet = waitBulletP;
		shotOutput = shotOutputP;
		bullet = bulletP;
		//bulletIcon = bulletIconP;

		StartCoroutine (RevertWeapon());
	}

	IEnumerator RevertWeapon()
	{
		yield return new WaitForSeconds (10);

		shotSpeed = shotSpeedOrg;
		bulletSpeed = bulletSpeedOrg;
		destroyTime = destroyTimeOrg;
		waitBullet = waitBulletOrg;
		shotOutput = shotOutputOrg;
		bullet = bulletOrg;
		//bulletIcon = bulletIconOrg;
	}

	void Update () {
        Shooting();
        //transform.Translate(Vector3.forward * shotSpeed * Time.deltaTime);
	}

    public void Shooting(){
        if (Input.GetButtonDown("Fire1")){
            //  GameObject newBullet = Instantiate(bullet, shotOutput.transform.position, Quaternion.identity) as GameObject;//ignore this line
			ShotWait ();
            //GameObject newBullet = Instantiate(bullet, shotOutput.transform.position, Quaternion.Euler(new Vector3(90, 270, 0))) as GameObject;
            GameObject newBullet = Instantiate(bullet, shotOutput.transform.position, Quaternion.Euler(new Vector3(0, 270, 0))) as GameObject;
            newBullet.GetComponent<Rigidbody>().AddForce(bullet.transform.right * -bulletSpeed);
            Destroy(newBullet, destroyTime);
       }
    }
	IEnumerator ShotWait() {
		yield return new WaitForSeconds(waitBullet);
	}
}
