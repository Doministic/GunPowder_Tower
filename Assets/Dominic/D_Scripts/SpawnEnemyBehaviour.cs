using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyBehaviour : MonoBehaviour {


	public GameObject enemyToSpawn;
	public List<GameObject> enemySpawnLocations = new List<GameObject>();
	public float startWait;
	public float spawnWait;
	public float waveWait;

	private int index;
	private int enemyCount;


	IEnumerator SpawnEnemyCoroutine(){	
		int minEnemyCount = 10;
		int maxEnemyCount = 50;
		enemyCount = Random.Range(minEnemyCount, maxEnemyCount);
		yield return new WaitForSeconds(startWait);
		while (true){
			for(int i = 0; i <= enemyCount; i++){
				SpawnEnemy();
				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds(waveWait);
		}

	}
	void Start()
	{	
		StartCoroutine(SpawnEnemyCoroutine());	
	}
	void Update()
	{
		index = Random.Range(0, enemySpawnLocations.Count);
		Debug.Log(index);	
	}
	void SpawnEnemy(){
		if (index == 0){
			float minX = -75.0f;
			float maxX = 75.0f;
			float randomX = Random.Range(minX, maxX);
			Vector3 spawnPoint0 = new Vector2(randomX, enemySpawnLocations[0].transform.position.y);
			Instantiate(enemyToSpawn, spawnPoint0, Quaternion.identity);
		}
		else if (index == 1){
			float minY = 0.0f;
			float maxY = 50.0f;
			float randomY = Random.Range(minY, maxY);
			Vector3 spawnPoint1 = new Vector2(enemySpawnLocations[1].transform.position.x, randomY);
			Instantiate(enemyToSpawn, spawnPoint1, Quaternion.identity);				
		}
		else if (index == 2){
			float minY = 0.0f;
			float maxY = 50.0f;
			float randomY = Random.Range(minY, maxY);
			Vector3 spawnPoint2 = new Vector2(enemySpawnLocations[2].transform.position.x, randomY);
			Instantiate(enemyToSpawn, spawnPoint2, Quaternion.identity);
		}
	}		
}
