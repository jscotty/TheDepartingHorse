using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float jumpSpeed;
	public float jumpCounter;
	private float jumpButtonCounter = 0;
	public bool catching;
	private bool pauseVisable;
	public bool jumping = false;

	//public bool jumpOff = false;
	//public DataClass dataClass;

	void Start(){
//		if (jumping == true) {
//			jumpSpeed += 1;		
//
//		}else{
//			jumpSpeed = -10;
//		}

	}

	void Update(){
		if(this.transform.position.y <= -10.5) Application.LoadLevel("Menu");

		/*if (jumping == true) {
			jumpCounter += 1;		
		} else{
			jumpCounter -=1;
		}
		if (jumpCounter <= 0) {
			jumpCounter = 0;	
		}
		if (jumpCounter <= 10) jumping = false;

		if(jumping == false){
			jumpButtonCounter += 1f;
			jumpSpeed = 20;
		}
		if(jumping == true){
			jumpButtonCounter -= 1f;
			jumpSpeed = 0;
		}
		if (jumpButtonCounter >= 0) {
			jumpButtonCounter = 0;		
		}
		if (jumpButtonCounter >= 10) {
			jumpButtonCounter -= 1;		
		}*/

		print ("jumping = " + jumping);
		//print ("jumpCounter = " + jumpCounter);


	}

	void OnTriggerEnter2D(Collider2D ground){
		if(ground.gameObject.tag == "Platform")
		{
			jumping = false;
		} else{
			jumping = true;
		}
	}

	void OnGUI(){

		if (GUI.RepeatButton (new Rect (10, 50, 150, 100), "Jump!")) {
			if(jumping == false){
				rigidbody2D.AddForce(Vector2.up * jumpSpeed);
			}else{
				//
			}
		}
		if (GUI.RepeatButton (new Rect (10, 250, 150, 100), "Catch!")) {
			catching = true;
		}else{
			catching = false;
			}
		

		// Pause button
		if (pauseVisable == true){
		if (GUI.Button (new Rect (Screen.width/1 -60, Screen.height /40 , 50, 50), "Pause")){
			DataClass.paused = true;
				pauseVisable = false;
			}
		}else{
		if (GUI.Button (new Rect (Screen.width/1 -60, Screen.height /40 , 50, 50), "Pause")){
			DataClass.paused = false;
				pauseVisable = true;
		}
		}

	}
}
