using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyBehaviourMain : MonoBehaviour
{

    public float timeCounter = 40.0f;
    public GameObject EnemyToSpawn;

    private bool isSpawning = false;
    IEnumerator SpawnEnemy()
    {

        Instantiate(EnemyToSpawn, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(4);

        isSpawning = false;

    }

    void Start()
    {
        //StartCoroutine(SpawnEnemy());
    }

    void Update()
    {
        timeCounter -= Time.deltaTime;
        if (timeCounter >= 0 && isSpawning == false)
        {
            isSpawning = true;
            StartCoroutine(SpawnEnemy());
        }
    }


}
