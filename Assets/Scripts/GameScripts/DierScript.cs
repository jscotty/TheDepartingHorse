using UnityEngine;
using System.Collections;

public class DierScript : ObjectScript {
	public float movementSpeed;
	private int counter = 0;
	private bool goToRight = false;

	void Update () {
		if (counter == 0) {
			goToRight = true;
		}
		if (counter == 101) {
			goToRight = false;
		}
		if (goToRight == true){
			transform.Translate (Vector2.right * movementSpeed);
			counter++;
		}
		if (goToRight == false) {
			transform.Translate (Vector2.right * -movementSpeed);
			counter--;
		}
	}
}