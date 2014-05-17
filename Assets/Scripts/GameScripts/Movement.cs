using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float offscreen;
	public float movementSpeed = 0.03f;

	public Paused paused;

	void Start(){
		paused = this.gameObject.GetComponent<Paused> ();
	}

	void Update(){

		movementSpeed += 0.00000001f;

		transform.Translate (Vector2.right * movementSpeed);

	}


}
