using UnityEngine;
using System.Collections;

public class DierScript : MonoBehaviour {
	public Transform animal;

	private float timer = 0;


	void Update () {
		timer += Time.deltaTime;
		if (timer >= 10) {
			SpawnAnimal ();
			timer = 0;
		}

		if (transform.position.x <= -43) {
			Destroy(gameObject);
		}

	}

	void SpawnAnimal(){
		Vector3 playerLocation = new Vector3 (30, 0, 0);
		Instantiate (animal, playerLocation, transform.rotation);
	}
	
	void OnCollisionEnter2D(Collision2D player)
	{
		if (player.transform.tag == "Player" && PlayerController.catching == false)
		{
			Destroy(player.gameObject);
		}
	}
}