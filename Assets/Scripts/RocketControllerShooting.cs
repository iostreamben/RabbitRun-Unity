using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketControllerShooting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D hitObject)
	{
		if (hitObject.gameObject.tag == "SpiderEnemy") {
			Destroy (hitObject.gameObject);
			ScoreManagerGL3.scoreValue = ScoreManagerGL3.scoreValue + 1;
		}
	}
}
