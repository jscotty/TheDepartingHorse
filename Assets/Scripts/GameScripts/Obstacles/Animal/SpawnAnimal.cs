using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnAnimal : MonoBehaviour {
	public Transform animal;
	public float spawnTimer;
	public GameObject[] animalList;
	private float timer = 0;

	void Start(){
		spawnTimer = Random.Range(2, 15);
	}
	
	void Update () {
		if(DataClass.paused == false){
		timer += Time.deltaTime;
		if (timer >= spawnTimer) {
			spawnTimer = Random.Range(2, 15);
			SpawnTheAnimal();
			timer = 0;
		}
		}else{}
	}

	void SpawnTheAnimal(){
		Vector3 playerLocation = new Vector3 (50, 1, 0);

		int animalIndex = Random.Range(0, animalList.Length);
		Instantiate (animalList[animalIndex], playerLocation, animal.transform.rotation);
	}
}
