using UnityEngine;
using System.Collections;

public class DierScript : ObjectScript {
	public Transform animal;

	public float movementSpeed;

	private int counter = 0;
	private float timer = 0;

	private bool goToRight = false;

	void Update () {
				if (counter == 0) {
						goToRight = true;
				} else if (counter == 101) {
						goToRight = false;
				}
				if (goToRight == true) {
						transform.Translate (Vector2.right * movementSpeed);
						counter++;
				} else if (goToRight == false) {
						transform.Translate (Vector2.right * -movementSpeed);
						counter--;
				}
		timer += Time.deltaTime;
		if (timer >= 10) {
			SpawnAnimal ();
			timer = 0;
		}

	}

	void SpawnAnimal(){
		Vector3 playerLocation = new Vector3 (30, 0, 0);
		Instantiate (animal, playerLocation, transform.rotation);
	}
}