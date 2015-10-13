using UnityEngine;
using System.Collections;

public class LerpyMover : MonoBehaviour {

	private Transform startPoint, endPoint;
	public float percentage;
	private int direction;
	public float speed = 2;

	// Use this for initialization
	void Start () {

		startPoint = GameObject.Find ("Point1").transform;
		endPoint = GameObject.Find ("Point2").transform;
		direction = 1;
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = 
		Vector3.Lerp (startPoint.position, endPoint.position, percentage);

		transform.rotation = Quaternion.Lerp 
							(Quaternion.identity, 
			 				Quaternion.Euler (new Vector3 (-90, 120, 3)),
			 				percentage);

		gameObject.GetComponent<Renderer> ().material.color =
		Color.Lerp (Color.red, Color.blue, percentage);

		speed = Mathf.Max (speed, .0000001f);
		percentage += Time.deltaTime/speed * direction;
		
		
		//keep percentage within range
		if (percentage > 1 || percentage < 0) {
			direction = -direction;
			percentage = Mathf.Clamp(percentage, 0, 1);
		}
		if (percentage < 0) {
			direction = -direction;
		}
	}
	}
