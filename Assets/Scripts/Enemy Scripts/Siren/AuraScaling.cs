using UnityEngine;
using System.Collections;

public class AuraScaling : MonoBehaviour {
    public float minScale;
    public float maxScale;

    bool big = false;
    bool small = true;
	
	// Update is called once per frame
	void Update ()
    {
        if(!big)
        {
            transform.localScale += new Vector3(0.02f * Time.deltaTime, 0.02f * Time.deltaTime, 0.02f * Time.deltaTime);
        }

        if (transform.localScale.x >= maxScale)
        {
            big = true;
            small = false;
        }

        if (!small)
        {
            transform.localScale -= new Vector3(0.02f * Time.deltaTime, 0.02f * Time.deltaTime, 0.02f * Time.deltaTime);
        }

        if (transform.localScale.x <= minScale)
        {
            small = true;
            big = false;
        }

    }
}
