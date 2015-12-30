using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// attach to floor
public class gameplay : MonoBehaviour {

	public GameObject box;
	public GameObject triangle;

	public float score;
	public float startTime;

	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (!box.GetComponent<Move> ().gameOver && triangle.GetComponent<triangle>().startGame)
			score += (Time.time- startTime);
		
		if (box.GetComponent<Move> ().gameOver) {
			Debug.Log (score);
		}
	}

	void OnCollisionEnter (Collision col)
	{		
		if (col.gameObject.name == "box") {
			if (triangle.GetComponent<triangle> ().startGame) {
				box.GetComponent<Move> ().gameOver = true;
			} 
		}
	}
}
