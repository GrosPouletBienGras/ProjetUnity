using UnityEngine;
using System.Collections;

public class itweenMove : MonoBehaviour {

	public Transform[] path;
	 float t = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion q = new Quaternion()  ;
		transform.position = Spline.MoveOnPath( iTweenPath.GetPath ("path1"), transform.position, ref t,ref q, 150.0f, 1000, EasingType.Sine, true, true);
		transform.rotation = q;		
		}
	}
	