using UnityEngine;
using System.Collections;

public class HeyLook : MonoBehaviour {
	
	public float speed;
	public float speed2;
	public bool IsClose = false; 
	public float rotation;
	private GameObject RightLim;
	private GameObject LeftLim;
	private GameObject bait;
	public GameObject bucket;
	public GameObject finish;
	

	// Use this for initialization
	void Start () {
	
		RightLim = GameObject.Find ("RIGHT limit");
		LeftLim = GameObject.Find ("LEFT limit");
		bait = GameObject.Find ("Bait PARENT");

	}
	
	// Update is called once per frame
	void Update () {

		if (IsClose == false) {
			transform.Translate (Vector3.forward * speed2 * Time.deltaTime);
			gameObject.transform.rotation = Quaternion.Euler(0,rotation,0);
			if (transform.position.x >= RightLim.transform.position.x && transform.rotation == Quaternion.Euler(0,90,0)){
				rotation *= -1;
			}
			if (transform.position.x <= LeftLim.transform.position.x && transform.rotation == Quaternion.Euler(0,-90,0)){
				rotation *= -1;
			}
		} 


		if (IsClose == true) {
			transform.LookAt (bait.transform);
			transform.Translate (Vector3.forward * speed * Time.deltaTime);
		}

	}

	void OnTriggerEnter(Collider other){ 
		if (other.gameObject.tag == "Player") {
			IsClose = true;
		}
		if (other.gameObject.tag == "Score") {
			bucket.GetComponent<AudioSource>().Play ();
			finish.GetComponent<SpriteRenderer>().enabled = true;
			finish.GetComponent<RestartMe>().enabled = true;
			Destroy (gameObject);
		}
	}

	void OnTriggerExit(Collider other){ 
		if (other.gameObject.tag == "Player") {
			IsClose = false;
		}
	}



}