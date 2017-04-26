using UnityEngine;
using System.Collections;

public class poopMovement : MonoBehaviour {
    public float poopSpeed;
    void Update()
    {
        transform.Translate(0, 0, poopSpeed * Time.deltaTime);

        if (transform.position.z > 5.6)
        {
            Destroy(gameObject);
        }
    }
}
