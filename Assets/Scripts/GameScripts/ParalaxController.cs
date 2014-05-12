using UnityEngine;
using System.Collections;

public class ParalaxController : MonoBehaviour {

	void Update () {
		renderer.material.mainTextureOffset = new Vector2 (Time.time * .01f, 1f);
	}
}
