using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    //private float startDelay = 1.0f;
    //private float spawnIntervalMin = 3.0f;
    //private float spawnIntervalAdd = 2.0f;
    private int ballIndex = 0;

    private float nextSpawnTime = 2.0f + Time.time; //2 seconds delay before first spawn
    private float spawnInterval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("CallInvoke", startDelay, spawnIntervalMin);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        ballIndex = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
    /*
    void CallInvoke()
    {
        Invoke("SpawnRandomBall", Random.Range(0, spawnIntervalAdd));
    }
    */
    void Update()
    {
        if(Time.time > nextSpawnTime)
        {
            SpawnRandomBall();
            nextSpawnTime = Time.time + Random.Range(3, 5);
            //spawnInterval += spawnIntervalAdd;
        }
    }
}

//In the above, tried to ways to create a random spawn interval. The first way was to use InvokeRepeating, it worked a little but was too complicated
//The second way is to use a timer in the Update method, which works but is much simplier.