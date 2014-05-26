using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	//private string title = "SHOP!";

	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width /2 -50, Screen.height /2 - 170, 150, 100), "START!")) {
			Application.LoadLevel ("JustinGame");	
		}
		/*if (GUI.Button (new Rect (Screen.width /2 -50, Screen.height /2, 150, 100), "Shop")){
			Application.LoadLevel ("Shop");	
		}*/

		//title = GUI.TextArea(new Rect(Screen.width / 2, 10, 60, 600), title, 25);

	}

}
