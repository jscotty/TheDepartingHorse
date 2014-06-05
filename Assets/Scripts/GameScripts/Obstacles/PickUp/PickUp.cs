using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
 	void OnCollisionEnter2D(Collision2D player)
	{
		if (player.transform.tag == "Player")
		{
			Destroy(gameObject);
			PickThePickUp();
		}
	}

	virtual protected void PickThePickUp()
	{
		print("Picked Up!");
	}
}
