using UnityEngine;
using System.Collections;

public class Shops : MonoBehaviour {

	public bool visible = true;
	
	public PowerUpStore powerUpStore;
	public RunStore runStore;
	public SpecialStore specialStore;
	public FlyStore flystore;

	void Start(){
		powerUpStore = this.gameObject.GetComponent<PowerUpStore> ();	
		flystore = this.gameObject.GetComponent<FlyStore> ();	
		runStore = this.gameObject.GetComponent<RunStore> ();	
		specialStore = this.gameObject.GetComponent<SpecialStore> ();	
	}
	void OnGUI(){

		if (visible == true) {
				if (GUI.Button (new Rect (200, Screen.height / 2 - 170, 150, 100), "Power Up")) {
					powerUpStore.visible = true;
					visible = false;
				}
				if (GUI.Button (new Rect (200, Screen.height / 2, 150, 100), "Fly upgrades")) {
					flystore.visible = true;
					visible = false;
				}
				if (GUI.Button (new Rect (400, Screen.height / 2 - 170, 150, 100), "Run upgrades")) {
					runStore.visible = true;
					visible = false;
				}
				if (GUI.Button (new Rect (400, Screen.height / 2, 150, 100), "Specials")) {
					specialStore.visible = true;
					visible = false;
				}
				if (GUI.Button (new Rect (400, Screen.height / 2 + 200, 150, 100), "Back to menu")) {
						Application.LoadLevel ("Menu");
				}
			} else{
		}
	}
}
