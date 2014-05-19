using UnityEngine;
using System.Collections;

public class Paused : MonoBehaviour {

	public bool pause = false;

	void OnGUI () {
		if (GUI.Button (new Rect (Screen.width/1 -60, Screen.height /40 , 50, 50), "Pause")){
			pause = true;
		}
	}

}
