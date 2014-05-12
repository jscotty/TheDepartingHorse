using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float jumpSpeed;

	void Update(){
			
	}
	void OnGUI(){
		if (GUI.RepeatButton (new Rect (10, 50, 150, 100), "Jump!")) {
			this.transform.Translate (new Vector2 (0, 1) * jumpSpeed * Time.deltaTime); 
		}
		
	}
}
