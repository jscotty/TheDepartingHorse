using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float movementSpeed = -0.01f;
	public Transform platform;

	void Update(){
		movementSpeed -= 0.00001f;

		transform.Translate(Vector2.right * movementSpeed);
	}


}
