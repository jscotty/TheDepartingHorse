using UnityEngine;
using System.Collections;

public class AnimalScript : MonoBehaviour {

	void Update(){
		if (transform.position.x <= -43) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D player)
	{
		if (player.transform.tag == "Player")
		{
			if(PlayerController.catching == false){
				Application.LoadLevel("JustinMenu");

		}else if (PlayerController.catching == true) {
			Destroy(gameObject);	
			DataClass.score += 10;
		}
		}
	}
}