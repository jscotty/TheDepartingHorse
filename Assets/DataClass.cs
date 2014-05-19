using UnityEngine;
using System.Collections;

public class DataClass : MonoBehaviour {

	public static bool paused = false;

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
}
