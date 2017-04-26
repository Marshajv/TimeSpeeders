using UnityEngine;
using System.Collections;

public class SeagullMovement : MonoBehaviour {
    public float enemySpeed;

    public Vector3 initPos;
    public Vector2 enemyWiggle;

    void Start()
    {
        initPos = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(initPos.x + Mathf.PingPong(Time.time * enemySpeed, enemyWiggle.x),
            transform.position.y, initPos.z + Mathf.PingPong(Time.time * enemySpeed, enemyWiggle.y));
    }
}