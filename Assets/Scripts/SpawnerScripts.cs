using UnityEngine;
using System.Collections;

public class SpawnerScripts : MonoBehaviour {
	private float spawnTime;
	private float SpawnDelay;
	public GameObject[] meteors;
	// Use this for initialization
	void Start () {
		spawnTime = Random.Range (1, 1);
		SpawnDelay = Random.Range (1, 2);
		InvokeRepeating ("SpawnMeteors", SpawnDelay, spawnTime);
	
	}
	
	// Update is called once per frame
	void SpawnMeteors()
	{
		int meteorsIndex = Random.Range (0, meteors.Length);
		Vector3 pos = transform.position;
		Instantiate (meteors [meteorsIndex], new Vector3 (pos.x + Random.Range (-6, 6), pos.y, pos.z), Quaternion.identity);
	}
}
