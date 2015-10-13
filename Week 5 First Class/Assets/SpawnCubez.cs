using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnCubez : MonoBehaviour {
	
	public Slider slidecount;
	public GameObject cubeSpawn;

	public string[] names = {"gertrude", "billy", "trump","crunchy", "milk", "anything"};

	public void bPress() {
		print ("pressed");

		//value is a float
		// you can´t stick a float into a int; use Mathf functions to convert

		int numCubes = Mathf.RoundToInt(slidecount.value);

		//where to start = 0
		//count until you reach = numCubes
		//count by = 1

		for (int count = 0; count < numCubes; count++) {
			GameObject justSpawnedCube = Instantiate(cubeSpawn, Random.insideUnitSphere * 10f, Quaternion.identity) as GameObject;
			justSpawnedCube.GetComponent<Rigidbody>().AddForce(Random.insideUnitSphere * 100);
			justSpawnedCube.GetComponentInChildren<Text>().text = names[Random.Range(0,names.Length)];
		}

}
}