using UnityEngine;
using System.Collections;

public class DierScript : ObjectScript {
	void Update () {
		if (transform.position.x == 13f) 
		{
			transform.position.x -= 0.01f;
		}
		if (transform.position.x == 6f) 
		{
			transform.position.x += 0.01f;
		}
	}
}
