using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class needleScript : MonoBehaviour {

	public chickenController controller;
	public float initialAngle, maxAngle, maxValue, minValue;
	float angle = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float value = ( controller.initialSpeed - minValue ) / (maxValue-minValue);
		angle = initialAngle + maxAngle * value;
		transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, angle);
	}
}
