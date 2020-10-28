using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GreenStoneController : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D hitObject)
	{
		if (hitObject.gameObject.name == "Messi") {
			Destroy (hitObject.gameObject);	
			System.Threading.Thread.Sleep(3000);
			SceneManager.LoadScene ("GameOver");
		}

	}
	float speed = 5.0f;
	void Update () {
		transform.Translate (Vector3.left * speed * Time.deltaTime);
	}
}
