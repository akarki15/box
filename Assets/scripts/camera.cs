using UnityEngine;
using System.Collections;


public class camera : MonoBehaviour {
	public GameObject box;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = new Vector3 (box.transform.position.x, transform.position.y, transform.position.z);
		this.transform.position = temp;
	}
}
