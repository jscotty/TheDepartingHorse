using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//public float jumpCounter;
	//private float jumpButtonCounter = 0;
	public static bool catching;
	public bool jumping = false;
	public bool pauseVisable = true;
	public GUIStyle style;
	private int catchCounter;
	public Texture jumpTexture;
	public Texture catchTexture;

	//public bool jumpOff = false;
	//public DataClass dataClass;

	void Start(){
		if(DataClass.paused == true){
			audio.Pause();
		}else{
			audio.Play();
		}
//		if (jumping == true) {
//			jumpSpeed += 1;		
//
//		}else{
//			jumpSpeed = -10;
//		}

	}

	void Update(){
		if(this.transform.position.y <= -10.5) Application.LoadLevel("JustinMenu");

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

		//print ("jumping = " + jumping);
		//print ("jumpCounter = " + jumpCounter);
		// ^^ was bedoelt voor jump systeem maar dit is gefixt door addForce
	}

	void OnTriggerEnter2D(Collider2D ground){
		if(ground.gameObject.tag == "Platform")
		{
			jumping = true;
		} else{ 				//als jumping = true kan de speler springen
			jumping = false;		//zo niet zal de speler naar beneden gaan.
		}
		//print (jumping);
	}

	void OnGUI(){
		GUI.skin.button = style;
		GUILayout.RepeatButton ("");

		if(pauseVisable == true){
			if (GUI.RepeatButton (new Rect (0, Screen.height/3 ,jumpTexture.width, jumpTexture.height),jumpTexture)) {
			if(jumping == true){
				rigidbody2D.AddForce(Vector2.up * DataClass.jumpSpeed);
				
			}
		}
		}else{}

		if(pauseVisable == true){
			if (GUI.RepeatButton (new Rect (Screen.width/2, Screen.height/3, catchTexture.width, catchTexture.height), catchTexture)) {
			catching = true;
		}else{
			catching = false;
			}
		}else{}

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
