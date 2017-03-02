using UnityEngine;
using System.Collections;

public class ObstacleMovement : MonoBehaviour {
    // Use this for initialization
    private float obstacleSpeed;
    public float minSpeed;
    public float maxSpeed;
	void Start () {
        obstacleSpeed = (Random.Range(minSpeed, maxSpeed));
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

public void Movement()
    {
        transform.Translate(Vector3.down*obstacleSpeed*Time.deltaTime);
    }

void OnTriggerEnter(Collider other)
    {
        if (other.name == ("RockDespawner"))
        {
            ObjectManager.rockTotal--;
            gameObject.SetActive(false);
        }
    }
}
