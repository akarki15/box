using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float speed = 2.0f;

	void Update() {
		var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
		transform.position += move * speed * Time.deltaTime;
	}
		
}