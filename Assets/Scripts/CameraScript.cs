using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

//	private float leftLimit;
//	private float rightLimit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftLimit, rightLimit), transform.position.y, transform.position.z);
		transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
	}
}
