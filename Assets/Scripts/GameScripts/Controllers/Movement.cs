using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float offscreen;
	public float movementSpeed = 0.03f;


	void Start(){
	}

	private float currentTime;

	void Update(){
<<<<<<< HEAD:Assets/Scripts/GameScripts/Controllers/Movement.cs
		if (DataClass.paused == true) {
			movementSpeed += 0;		
		}else{
			
		movementSpeed += 0.000004f;

		transform.Translate (Vector2.right * movementSpeed);
		}
=======
			
		movementSpeed += 0.00001f;

		transform.Translate (Vector2.right * movementSpeed);
		
>>>>>>> 4665b3dceec0531a639a8c0775fe970a24ad0097:Assets/Scripts/GameScripts/Movement.cs


	}
}
