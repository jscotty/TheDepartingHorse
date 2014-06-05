using System;
using UnityEngine;
using System.Collections;

public class DataClass : MonoBehaviour {

	public static bool paused = false;
	public static float score = 8000;
	public static float meters;
	public static float speed;
	public static float scrollBackground;
	public static float scrollFront;
	public static float movementSpeed;
	public static float jumpSpeed;

	public float scoreCounter;

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}

	void Start(){
		speed = 0.0000008f;
		scrollFront = 0.000001f;
		scrollBackground = 0.00000005f;
		movementSpeed = 0.1f;
		jumpSpeed = 30f;
	}

	void Update(){
		movementSpeed += speed;
		if(paused == true){

		}else{
		movementSpeed += speed;

		scoreCounter += 1;

			if(scoreCounter >= 60f){
				scoreCounter = 0f;
				score += 1;
			}else if(scoreCounter == 30){
				meters += 1;
			}
		}
	}
}
