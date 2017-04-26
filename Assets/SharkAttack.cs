using UnityEngine;
using System.Collections;
//im just usig this script to manage animations not for actual enemy detection.
public class SharkAttack : MonoBehaviour {
    public float playerDist;
    public float attckDist;

    public Transform player;

    bool isAttacking = false;
    void Start () {
        playerDist = Vector3.Distance(player.position, transform.position);
        if (playerDist < attckDist)
        {
            isAttacking = true;
            //get attack animation
        }else{
            //get idle animation
        }
    }
	void Update () {
	
	}

}
