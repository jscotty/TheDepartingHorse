using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float offscreen;
	public float movementSpeed = 0.03f;


	void Start(){
	}

	private float currentTime;

	void Update(){
		if (DataClass.paused == true) {
			movementSpeed += 0;		
		}else{
			
		movementSpeed += 0.000004f;

		transform.Translate (Vector2.right * movementSpeed);
		}


	}
}
