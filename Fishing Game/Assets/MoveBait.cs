using UnityEngine;
using System.Collections;

public class MoveBait : MonoBehaviour {
	

	public float speed;
	public GameObject fish;
	public GameObject bait;
	public GameObject baitchild;
	public GameObject bubbles;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.A)) {
			if (transform.position.x >= -4.1f) {
				transform.Translate (-Vector3.right * speed * Time.deltaTime);
			}
		}
		if (Input.GetKey (KeyCode.D)) {
			if (transform.position.x <= 4.87f) {
				transform.Translate (Vector3.right * speed * Time.deltaTime);
			}
		}
		if (Input.GetKey (KeyCode.S)) {
			if (transform.position.y >= -3f) {
				transform.Translate (-Vector3.up * speed * Time.deltaTime);
			}
		}
		if (Input.GetKey (KeyCode.W)) {
			if (transform.position.y <= 2.29f) {
				transform.Translate (Vector3.up * speed * Time.deltaTime);
			}
		}
	}

	
	void OnTriggerEnter(Collider other){ 
		if (other.gameObject.tag == "Fish"){
			gameObject.GetComponent<AudioSource>().Play();
			fish.transform.parent = baitchild.transform;
			fish.GetComponent<HeyLook>(). enabled = false;
			baitchild.GetComponent<Animator>().enabled = false;
			fish.GetComponent<BoxCollider>().enabled = false;
			bubbles.GetComponent<SpriteRenderer>().enabled = false;
		}
		if (other.gameObject.tag == "Water") {
			print("hey");
			gameObject.GetComponent<TrailRenderer> ().time = 0.6f;
			baitchild.GetComponent<Animator>().enabled = true;
		}
}

	void OnTriggerExit(Collider other){ 
	if (other.gameObject.tag == "Water") {
		print("hey");
		gameObject.GetComponent<TrailRenderer> ().time = 0;
		baitchild.GetComponent<Animator>().enabled = false;	
	}
	
}

}
