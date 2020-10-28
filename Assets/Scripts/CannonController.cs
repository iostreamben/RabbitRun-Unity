using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var moveV = Input.GetAxis ("Vertical") * 0.6f;
		transform.Translate (0,moveV,0);

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			FireBullet ();
		}
	}

	public GameObject rocketPrefabs;
	public Transform bulletOutPosition;
	GameObject rocket;
	void FireBullet()
	{
		rocket = Instantiate (rocketPrefabs);
		rocket.transform.position = bulletOutPosition.position;
		rocket.GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 1000);
	}
}
