using UnityEngine;
using System.Collections;

public class ParalaxController : MonoBehaviour {
	public float paralScrollSpeed = 0.05f;
	private float scrollSave;
	public float speed = 0.0001f;

	void Update () {
		if (DataClass.paused == true) {
			speed += 0f;
			paralScrollSpeed = scrollSave;
		}else{
			speed += 0.00000005f;
			paralScrollSpeed += speed;
			renderer.material.mainTextureOffset = new Vector2 (paralScrollSpeed, 1f);
		}
		scrollSave = paralScrollSpeed;
	}
}
