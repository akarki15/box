using UnityEngine;
using System.Collections;

public class triangle : MonoBehaviour {
	public bool startGame;
	// Use this for initialization
	public GameObject floor;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.name == "box"  && !startGame) {
			startGame = true;
			floor.GetComponent<gameplay>().startTime = Time.time;
			Debug.Log (floor.GetComponent<gameplay> ().startTime);
		} 
	}

}
