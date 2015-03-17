using UnityEngine;
using System.Collections;

public class chickenVersusScript : MonoBehaviour {


	public float speed = 50.0f, turnNumber = 0;
	public chickenController player;
	Animator animator;

	[HideInInspector] 
	public float t;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		animator.speed = Mathf.Min( ( speed  ) / 50 , 2);

		if (player.t > this.t && player.turnNumber >= this.turnNumber) {
			speed +=   5f  ;
			if( speed > 210 )
				speed = 210;
		} 
		
		else {
			speed -= 1f;
			if( speed < 20 )
				speed = 20;
		}



		Quaternion q = new Quaternion()  ;
		transform.position = Spline.MoveOnPath( iTweenPath.GetPath ("leftPath"), transform.position, ref t,ref q, speed, 1000, EasingType.Sine, true, true);
		transform.rotation = q;	
	}
}
