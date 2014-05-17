using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float jumpSpeed;
	public Paused paused;
	void Start(){
		paused = this.gameObject.GetComponent<Paused>();
	}

	void Update(){
		if(this.transform.position.y <= -10.5) Application.LoadLevel("Menu");
	}
	void OnGUI(){
		if (GUI.RepeatButton (new Rect (10, 50, 150, 100), "Jump!")) {
			if(paused.pause == true){
			
			}else this.transform.Translate (new Vector2 (0, 1) * jumpSpeed * Time.deltaTime); 
		}
		
	}
}
