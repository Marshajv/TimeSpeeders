using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectManager : MonoBehaviour
{
    public List<GameObject> obstacles;
    public List<GameObject> rockSpawners;
    [HideInInspector]
    public List<GameObject> rockSpawnerOriginal;
    public float objWait;

    public int rockMax;
    public static int rockTotal;

    private bool waiting;
    private GameObject chosenObs;

    ObjectPooling objectPool;
    GameObject spawnPointManager;

	void Start ()
    {
        spawnPointManager = GameObject.Find("SpawnPointsManager");
        objectPool=GameObject.Find("ObstaclePool").GetComponent<ObjectPooling>();
        foreach(GameObject go in rockSpawners)
        {
            rockSpawnerOriginal.Add(go);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (rockTotal < rockMax && !waiting)
        {
            waiting = true;
            rockTotal++;
            //chosenObs = obstacles[Random.Range(0, obstacles.Count)];
            //Instantiate(chosenObs, rockSpawners[Random.Range(0, rockSpawners.Length)].transform.position, chosenObs.transform.rotation);

            GameObject obj = objectPool.GetPooledObject();

            if (obj == null)
            {
                return;
            }

            if(rockSpawners.Count <= 0)
            {
                foreach (GameObject go in rockSpawnerOriginal)
                {
                    rockSpawners.Add(go);
                }
            }
            chosenObs = rockSpawners[Random.Range(0, rockSpawners.Count)];
            obj.transform.position = chosenObs.transform.position;
            rockSpawners.Remove(chosenObs);
            obj.SetActive(true);

            StartCoroutine(ObjectWait());
        }
	}
    IEnumerator ObjectWait()
    {
        yield return new WaitForSeconds(objWait);
        waiting = false;
    }

    void CheckList()
    {

    }
}
