using UnityEngine;
using System.Collections;

public class cameraLookAt : MonoBehaviour {

	public GameObject poulet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (poulet.transform.position);

	}
}
