using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	float direction = 1;
	// Update is called once per frame
	void Update () 
	{
	//	transform.Translate( 5.0f* Time.deltaTime * Vector3.down );
		if ( transform.position.y > 6.2 )
		{
			direction = -1;
		}
		else if( transform.position.y < -4.0 )
		{
			direction = 1;
		}
		
		transform.Translate( 0,
			5.0f* Time.deltaTime * direction,
			                 0);
		
	}
}
