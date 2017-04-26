using UnityEngine;
using System.Collections;

public class ObstacleMovementAlt : MonoBehaviour {
    private float obstacleSpeed;
    public float minSpeed;
    public float maxSpeed;
    void Start()
    {
        obstacleSpeed = (Random.Range(minSpeed, maxSpeed));
    }
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        transform.Translate(Vector3.forward * obstacleSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == ("RockDespawner"))
        {
            ObjectManager.rockTotal--;
            Respawn();
          //  gameObject.SetActive(false);
        }
    }

    void Respawn()
    {
        transform.position = new Vector3(Random.Range(-6, 6), 0.68f, Random.Range(-50, -35));
    }
}