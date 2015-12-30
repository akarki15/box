using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float speed = 1.0f;
	public bool debugMode;
	public int strength;

	void Start(){
		debugMode = true;
	}



	void Update() {
		if (Input.touchCount == 1)
		{
			var touch = Input.touches[0];
			if (touch.position.x < Screen.width/2)
			{
				transform.position -= new Vector3(1f, 0, 0) * speed * Time.deltaTime;
			}
			else if (touch.position.x > Screen.width/2)
			{
				transform.position += new Vector3(1f, 0, 0) * speed * Time.deltaTime;
			}
		}
		if (debugMode){
			if (Input.GetAxis ("Horizontal") > 0) {
				Debug.Log ("right");
				Vector3 dir = new Vector3 (100f, 0f, 0f);
				dir.Normalize ();
				this.gameObject.GetComponent<Rigidbody>().AddForce (dir*10);
	
			} else if (Input.GetAxis ("Horizontal"q) < 0) {
				Debug.Log ("left");
				Vector3 dir = new Vector3 (-100f, 0f, 0f);
				dir.Normalize ();
				this.gameObject.GetComponent<Rigidbody>().AddForce (dir*10);
			}
		}

	}
		
}