using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

		public float offscreen;
		
		void Update () 
		{
			
			while (transform.position.x <= offscreen)
			{
			transform.position = new Vector2(92.04021f,-7.3f);
			}
		}
	}
