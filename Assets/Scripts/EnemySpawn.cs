using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
	public GameObject enemy;
	public GameObject spawnPoint;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	void Start()
	{
		StartCoroutine(SpawnWaves());

	}

	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds(startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				Instantiate(enemy, spawnPoint.transform.position, spawnPoint.transform.rotation);
				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds(waveWait);
		}
	}
}
