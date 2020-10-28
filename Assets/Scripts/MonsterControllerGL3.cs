using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MonsterControllerGL3 : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D hitObject)
	{
		if (hitObject.gameObject.name == "cannon") {
			Destroy (hitObject.gameObject);	
			System.Threading.Thread.Sleep(3000);
			SceneManager.LoadScene ("GameOver");		
		}
		
		if (hitObject.gameObject.name == "cannon") {
			Destroy (hitObject.gameObject);
			System.Threading.Thread.Sleep(3000);
			SceneManager.LoadScene ("GameOver");
		}

		if (hitObject.gameObject.name == "cannon") {
			Destroy (hitObject.gameObject);
			System.Threading.Thread.Sleep(3000);
			SceneManager.LoadScene ("GameOver");
		}

		if (hitObject.gameObject.name == "cannon") {
			Destroy (hitObject.gameObject);	
			System.Threading.Thread.Sleep(3000);
			SceneManager.LoadScene ("GameOver");
		}

		if (hitObject.gameObject.name == "cannon") {
			Destroy (hitObject.gameObject);
			System.Threading.Thread.Sleep(3000);
			SceneManager.LoadScene ("GameOver");
		}
	}

}
