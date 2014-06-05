using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float offscreen;


	void Start(){
	}

	private float currentTime;

	void Update(){
		if (DataClass.paused == true) {
			DataClass.movementSpeed += 0;		
		}else{
			
	

		transform.Translate (Vector2.right * DataClass.movementSpeed);
		}

	}
}
