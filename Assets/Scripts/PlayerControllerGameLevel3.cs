using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerGameLevel3 : MonoBehaviour {



	// Update is called once per frame
	void Update () {
		var moveH = Input.GetAxis ("Horizontal") * 0.2f;
		transform.Translate (moveH, 0, 0);
	}

	void OnCollisionEnter2D (Collision2D hitObject)
	{
		if (hitObject.gameObject.name == "SpiderB(Clone)")
		{
			hitObject.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 10.0f, ForceMode2D.Impulse);
			ScoreManager.scoreValue = ScoreManager.scoreValue + 100;
		}

	}

}
