using UnityEngine;
using System.Collections;

public class chickenController : MonoBehaviour {


	public float initialSpeed = 50.0f, speedGain = 0.5f, maxSpeed = 200.0f,turnNumber  = 0 ;
	public GameObject Q_key, D_key;
	public string path = "rightPath";
	bool rightKey = true;

	[HideInInspector]
	public float t;

	Animator animator;
	// Use this for initialization
	void Start () {
		 animator = GetComponent<Animator> ();
		setNextKey(Q_key, true);
		setNextKey(D_key, false);
	}
	
	// Update is called once per frame
	void Update () {
		animator.speed = Mathf.Min( ( initialSpeed  ) / 50 , 2);

		Quaternion q = new Quaternion()  ;
		transform.position = Spline.MoveOnPath( iTweenPath.GetPath (path), transform.position, ref t,ref q, initialSpeed, 1000, EasingType.Sine, true, true);
		transform.rotation = q;	
		//Debug.Log (" t = " + t);

		if (Input.GetKeyDown ("a")) {
			path = " leftpath";
				}

		if (Input.GetKeyDown ("q")) {
			if(rightKey){
				initialSpeed += speedGain;
				if(initialSpeed > maxSpeed) initialSpeed = maxSpeed;
				rightKey = !rightKey;
				setNextKey(Q_key, false);
				setNextKey(D_key, true);
			}
			else{
				initialSpeed -= 5 * speedGain + 10;
				if(initialSpeed < 10) initialSpeed = 10;

			}
		}
		else if (Input.GetKeyDown ("d")) {
			if(!rightKey){
				initialSpeed +=speedGain;
				if(initialSpeed > maxSpeed) initialSpeed = maxSpeed;
				rightKey = !rightKey;
				setNextKey(Q_key, true);
				setNextKey(D_key, false);

			}
			else{
				initialSpeed -= 5 * speedGain + 10;
				if(initialSpeed < 10) initialSpeed = 10;

			}
		}
		else{
			initialSpeed -=  speedGain / 8 ;
			if(initialSpeed < 10) initialSpeed = 10;

		}

	}

	void setNextKey(GameObject key, bool next){
		if (next){
			key.GetComponent<SpriteRenderer>().color = new Color(key.GetComponent<SpriteRenderer>().color.r,
		                                                                 key.GetComponent<SpriteRenderer>().color.g,
		                                                                 key.GetComponent<SpriteRenderer>().color.b,
		                                                                 1.0f);
		}
		else{
			key.GetComponent<SpriteRenderer>().color = new Color(key.GetComponent<SpriteRenderer>().color.r,
		                                                             key.GetComponent<SpriteRenderer>().color.g,
		                                                             key.GetComponent<SpriteRenderer>().color.b,
		                                                             0.5f);
		}
				

	}

}

