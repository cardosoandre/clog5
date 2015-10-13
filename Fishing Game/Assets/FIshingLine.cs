using UnityEngine;
using System.Collections;

public class FIshingLine : MonoBehaviour {

	LineRenderer line;
	private Vector3 myLocation;
	private GameObject Bait;


	// Use this for initialization
	void Start () {
	
		Bait = GameObject.Find ("Lure Position");

	}

	// Update is called once per frame
	void Update () {
		line = transform.GetComponent<LineRenderer> ();
		line.SetVertexCount (2);
		line.SetPosition (0, gameObject.transform.position);
		line.SetPosition (1, Bait.transform.position);

	}
}
