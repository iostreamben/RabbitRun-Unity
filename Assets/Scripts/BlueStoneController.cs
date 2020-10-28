using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class BlueStoneController : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D hitObject)
	{
		if (hitObject.gameObject.name == "Messi") {
			Destroy (gameObject);	
			ScoreManagerGL2.scoreValue = ScoreManagerGL2.scoreValue + 1;
		}

	}
	float speed = 5.0f;
	void Update () {
		transform.Translate (Vector3.left * speed * Time.deltaTime);
	}
}
