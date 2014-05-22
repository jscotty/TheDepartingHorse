using UnityEngine;
using System.Collections;

public class ParallaxFront : MonoBehaviour {

		public float paralScrollSpeed = 0.05f;
		private float speed = 0.005f;
		
		void Update () {
		if (DataClass.paused == true) {
			speed += 0f;
			paralScrollSpeed = 0f;
		}else{
			speed += 0.0000002f;
		}
			paralScrollSpeed += speed;
			renderer.material.mainTextureOffset = new Vector2 (paralScrollSpeed, 1f);
		}
	}
