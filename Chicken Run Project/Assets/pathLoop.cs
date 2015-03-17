using UnityEngine;
using System.Collections;

public class pathLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.tag.Contains ("Player")) {
			other.GetComponent<chickenController>().t = 0;
			other.GetComponent<chickenController>().turnNumber++;

				}
		else if (other.tag.Contains ("IA")) {
			other.GetComponent<chickenVersusScript>().t = 0;
			other.GetComponent<chickenVersusScript>().turnNumber++;
		}
	}
}
