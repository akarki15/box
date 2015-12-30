using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float speed = 2.0f;
	public bool gameOver=false;
	void Update() {
		if (!gameOver) {
			var move = new Vector3 (Input.GetAxis ("Horizontal"), 0, 0);
			transform.position += move * speed * Time.deltaTime;

			if (Input.touchCount == 1) {
				var touch = Input.touches [0];
				if (touch.position.x < Screen.width / 2) {
					transform.position -= new Vector3 (1f, 0, 0) * speed * Time.deltaTime;
				} else if (touch.position.x > Screen.width / 2) {
					transform.position += new Vector3 (1f, 0, 0) * speed * Time.deltaTime;
				}
			}
		}
	}
}