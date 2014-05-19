using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

	public float jumpSpeed;
	public bool catching;

	//public DataClass dataClass;

	void Start(){

		//GameObject dataClass = GameObject.Find ("Data");
		//dataClass = GetComponent<DataClass> ();
	}

	void Update(){
		if(this.transform.position.y <= -10.5) Application.LoadLevel("Menu");
	}
	void OnGUI(){
		if (GUI.RepeatButton (new Rect (10, 50, 150, 100), "Jump!")) {
			 this.transform.Translate (new Vector2 (0, 1) * jumpSpeed * Time.deltaTime); 
		}
		if (GUI.RepeatButton (new Rect (10, 250, 150, 100), "Catch!")) {
			catching = true;
		}else{
			catching = false;
		}
		if (GUI.Button (new Rect (Screen.width/1 -60, Screen.height /40 , 50, 50), "Pause")){
			//
		}else{

		}
		print (DataClass.paused);

	}
}
