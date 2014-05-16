using UnityEngine;
using System.Collections;

public class Dog : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Camera.mainCamera.transform.position.z >= (this.transform.position.z + 20)) {
			this.transform.position += new Vector3(0, 0, 60);
		}
		transform.position += transform.up * Time.deltaTime;
	}
}
