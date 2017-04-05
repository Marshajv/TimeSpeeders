using UnityEngine;
using System.Collections;

public class WhirlShots : MonoBehaviour {
    public float destructionTime;
    public float projSpeed;

    void Start()
    {
        StartCoroutine(BulletDestruction());
    }
    void Update()
    {
        transform.Translate(Vector3.forward * projSpeed * Time.deltaTime);
    }

    IEnumerator BulletDestruction()
    {
        yield return new WaitForSeconds(destructionTime);
        Destroy(gameObject);
    }
}
// Use this for initialization
//    void Start()
//    {
//        StartCoroutine(BulletDestruction());
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        transform.Translate(Vector3.forward * wavProjSpeed * Time.deltaTime);
//    }

//    IEnumerator BulletDestruction()
//    {
//        yield return new WaitForSeconds(wavDestructionTime);
//        Destroy(gameObject);
//    }
//}
