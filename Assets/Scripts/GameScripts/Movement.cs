using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float offscreen;
	public float movementSpeed = 0.03f;


	void Start(){
	}

	private float currentTime;

	void Update(){
			
		movementSpeed += 0.00000001f;

		transform.Translate (Vector2.right * movementSpeed);
		


	}
}
