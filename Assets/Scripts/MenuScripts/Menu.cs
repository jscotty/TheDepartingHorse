using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	void OnGUI(){
		if (GUI.Button (new Rect (10, 10, 150, 100), "START!"))
						Application.LoadLevel ("Game");
		
	}
}
