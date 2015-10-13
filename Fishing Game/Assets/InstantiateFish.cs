using UnityEngine;
using System.Collections;

public class InstantiateFish : MonoBehaviour {

	public GameObject fish;

	// Use this for initialization
	void Start () {

		Instantiate (fish, transform.position, transform.rotation);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
