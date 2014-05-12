using UnityEngine;
using System.Collections;

public class PlatformSpawn : MonoBehaviour {

	public float spawnTime;
	public float spawnDelay;

	public GameObject[] platforms;

	public Transform spawn;
	public Vector2 spawnPos;

	public Random randomSpawn;

	void Start () {
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
		
		spawnPos = spawn.position;
	}
	
	// Update is called once per frame
	void Spawn () {
	
	}
}
