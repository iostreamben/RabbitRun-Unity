using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	float speed = 5.0f;
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * speed * Time.deltaTime);
	}
}
