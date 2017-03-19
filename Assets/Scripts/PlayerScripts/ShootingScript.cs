using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {
    public float shotSpeed;
	[Tooltip("This is the Shot output speed")]
    public float bulletSpeed;
    public float destroyTime;
	public float waitBullet;

    public GameObject shotOutput;
    public GameObject bullet;

	void Start () {
	
	}

	void Update () {
        Shooting();
        //transform.Translate(Vector3.forward * shotSpeed * Time.deltaTime);
	}

    public void Shooting(){
        if (Input.GetButtonDown("Fire1")){
            //  GameObject newBullet = Instantiate(bullet, shotOutput.transform.position, Quaternion.identity) as GameObject;//ignore this line
			ShotWait ();
			GameObject newBullet = Instantiate(bullet, shotOutput.transform.position, Quaternion.Euler(new Vector3(90, 270, 0))) as GameObject;
			newBullet.GetComponent<Rigidbody>().AddForce(bullet.transform.right * -bulletSpeed);
            Destroy(newBullet, destroyTime);
       }
    }
	IEnumerator ShotWait() {
		yield return new WaitForSeconds(waitBullet);
	}
}
