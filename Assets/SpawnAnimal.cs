using UnityEngine;
using System.Collections;

public class SpawnAnimal : MonoBehaviour {
	public Transform animal;
	public float spawnTimer = 10;
	
	private float timer = 0;
	
	
	void Update () {
		timer += Time.deltaTime;
		if (timer >= spawnTimer) {
			SpawnTheAnimal();
			timer = 0;
		}
	}

	void SpawnTheAnimal(){
		Vector3 playerLocation = new Vector3 (30, 20, 0);
		Instantiate (animal, playerLocation, transform.rotation);
	}
}
