using UnityEngine;
using System.Collections;

public class HeyLook : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {
	
		target = GameObject.Find ("Lerpy").transform;
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.LookAt (target);

	}
}
