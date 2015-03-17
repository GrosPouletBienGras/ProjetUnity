using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.velocity = new Vector2 (-10, 0);
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetKeyDown ("a")) {
			Debug.Log("yolo");
				}
	}
}
