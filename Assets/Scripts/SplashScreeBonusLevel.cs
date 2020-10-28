using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreeBonusLevel : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Invoke("ChangeScreenToGameMenuFor3Sec", 3.0f);
	}

	public void ChangeScreenToGameMenuFor3Sec()
	{
		SceneManager.LoadScene("GameShooting");
	}

	// Update is called once per frame
	void Update () {

	}
}
