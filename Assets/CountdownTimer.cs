using UnityEngine;
using System.Collections;

public class CountdownTimer : MonoBehaviour {
    [Tooltip("time porportional to seconds for 2.5 minutes == 230.0 f;")]
    public float timeLeft;
    private bool isSpawned =false;
    public GameObject leviEnemy;
    void Update () {
            timeLeft -= Time.deltaTime;
            //Debug.Log( "Time Left:" + Mathf.Round(timeLeft));
        if (timeLeft <= 0 && isSpawned == false)
        {
            Instantiate(leviEnemy);
            isSpawned = true;
        }
    }
}
