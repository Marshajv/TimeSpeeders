using UnityEngine;
using System.Collections;

public class BulletForce : MonoBehaviour {
	public float destructionTime;
	public float projSpeed;

	// Use this for initialization
	void Start () {
		StartCoroutine (BulletDestruction ());
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * projSpeed*Time.deltaTime);
	}

	IEnumerator BulletDestruction(){
		yield return new WaitForSeconds (destructionTime);
		Destroy (gameObject);
	}
}
