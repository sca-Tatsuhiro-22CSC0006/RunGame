using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject obstaclePrefab2;
    private Vector3 spawnPos = new Vector3(25,1,0);
    private Vector3 spawnPos2 = new Vector3(35, 4, 0);
    private float startDelay = 2;//’x‰„
    private float repeatRate = 2;//ŒJ‚è•Ô‚µŽžŠÔ
    private Pleyer_Controller pc;
   void Start()
    {
        InvokeRepeating("SpawnObstacle",startDelay,repeatRate);
        pc = GameObject.Find("Farmer").GetComponent<Pleyer_Controller>();
    }

    void SpawnObstacle()
    {
        if (!pc.gameOver)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }

        if (!pc.gameOver)
        {
            Instantiate(obstaclePrefab2, spawnPos2, obstaclePrefab2.transform.rotation);
        }
    }
}
