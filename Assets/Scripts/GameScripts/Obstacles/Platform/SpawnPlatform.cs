using UnityEngine;
using System.Collections;

public class SpawnPlatform : MonoBehaviour {

	public GameObject[] platform;

	void Start(){
	}

	void Update(){
		if(Respawn.spawn == true){
			int platformIndex = Random.Range(0, platform.Length);
			Instantiate (platform[platformIndex], transform.position, transform.rotation);
			Respawn.spawn = false;
		}else{

		}
	}
}
