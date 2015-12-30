using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// attach to floor
public class gameplay : MonoBehaviour {
	bool startGame;
	public GameObject box;
	void Start () {
		startGame = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision col) {
		Debug.Log ("AASHISH");
		if (col.gameObject.name == "box") {
			if (!startGame) {
				startGame = true;
			} else {
				Debug.Log ("DAMN");
				box.GetComponent<Move> ().gameOver = true;
			}
		}

	}
	void OnCollisionExit (Collision col) {
		
	}
}
