using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

		public float offscreen;
		public static bool spawn;
		void Update () 
		{
			if (transform.position.x <= offscreen)
			{
				//Spawn();
				//transform.position = new Vector2(92.04021f,-4.765321f);
				spawn = true;
				Destroy(gameObject);
			}
		}
		
		
	}
