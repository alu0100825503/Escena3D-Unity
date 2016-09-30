using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Renderer> ().material.color = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		this.gameObject.GetComponent<Rigidbody>().AddForce (transform.forward * 1000);
	}
}