using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedOrbController : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D hitObject)
	{
		if (hitObject.gameObject.name == "Me") {
			Destroy (gameObject);	
			TimeManager.timeValue = TimeManager.timeValue - 5;
		}

	}

}
	