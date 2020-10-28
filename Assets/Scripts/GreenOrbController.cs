using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenOrbController : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D hitObject)
	{
		if (hitObject.gameObject.name == "Me") {
			Destroy (gameObject);	
			ScoreManagerGL1.scoreValue = ScoreManagerGL1.scoreValue + 1;
		}

	}

}

