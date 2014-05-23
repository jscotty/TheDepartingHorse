using UnityEngine;
using System.Collections;

public class DierScript : MonoBehaviour {

	void Update(){
		if (transform.position.x <= -43) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D player)
	{
		if (player.transform.tag == "Player" && PlayerController.catching == false)
		{
			Destroy(player.gameObject);
		}
	}
}