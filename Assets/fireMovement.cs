using UnityEngine;
using System.Collections;

public class fireMovement : MonoBehaviour {
    public float fireSpeed;
    void Update()
    {
        transform.Translate(0, 0, fireSpeed * Time.deltaTime);

        if (transform.position.z > 5.6)
        {
            Destroy(gameObject);
        }
    }
}
