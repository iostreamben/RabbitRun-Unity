﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if( Input.GetKey( KeyCode.D ))
		{
			transform.Translate(2.0f * Time.deltaTime * -3,
						     0,
							 0);
			Debug.Log("D time "+ Time.deltaTime);
		}
		if( Input.GetKey( KeyCode.A ))
		{
			transform.Translate(2.0f * Time.deltaTime * 3,
								0,
								0);
			Debug.Log("D time "+ Time.deltaTime);
		}
	}


}
