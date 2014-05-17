using UnityEngine;
using System.Collections;

public class FlyStore : MonoBehaviour {

	public bool visible = false;
	public Shops shops;
	
	void Start(){
		shops = this.gameObject.GetComponent<Shops>();
	}
	
	void OnGUI () {
		if(visible == true){
			if (GUI.Button (new Rect (200, Screen.height / 2 - 170, 150, 100), "More Fly speed")) {
				//	
			}
			if (GUI.Button (new Rect (10, Screen.height / 2 - 170, 150, 100), "Back to shops")) {
				shops.visible = true;
				visible = false;
			}
		}else{
		}
	}
}
