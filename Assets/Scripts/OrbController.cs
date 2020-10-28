using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbController : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D hitObject)
	{
		if (hitObject.gameObject.name == "Me") {
			
			TimeManager.timeValue = TimeManager.timeValue - 5;

		}
		if (hitObject.gameObject.name == "H2") {
			Destroy (hitObject.gameObject);	
			LifeManager.lifeValue = LifeManager.lifeValue - 1;

		}
		if (hitObject.gameObject.name == "H3") {
			Destroy (hitObject.gameObject);	
			LifeManager.lifeValue = LifeManager.lifeValue - 1;

		}
		if (hitObject.gameObject.name == "H4") {
			Destroy (hitObject.gameObject);	
			LifeManager.lifeValue = LifeManager.lifeValue - 1;

		}
		if (hitObject.gameObject.name == "H5") {
			Destroy (hitObject.gameObject);	
			LifeManager.lifeValue = LifeManager.lifeValue - 1;

		}
	}

}
