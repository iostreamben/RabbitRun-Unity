using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RocketController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Space)) {
		
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 200);
		}
	
	}

	/*void OnCollisionEnter2D(Collision2D hitObject)
	{
		if (hitObject.gameObject.name == "Comet(Clone)") {
			Destroy (gameObject);
			System.Threading.Thread.Sleep(3000);
			SceneManager.LoadScene ("GameOver");
		}
	}*/
}
