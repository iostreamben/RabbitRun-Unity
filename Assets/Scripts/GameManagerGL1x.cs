using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManagerLevel1x : MonoBehaviour {

	public GameObject RedOrbPrefabs;

	GameObject CloneOrbX;
	public GameObject[] spawnPointArrayX;


	public void generateOrbAtSpawnPointX()
	{
		CloneOrbX = Instantiate (RedOrbPrefabs);
		int spawnPointIndex1 = Random.Range (6, 10);
		CloneOrbX.transform.position = spawnPointArrayX [spawnPointIndex1].transform.position;
		//new vector3(0,4,0);
		Destroy(CloneOrbX, 3.0f);

	}
	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("generateOrbAtSpawnPoint",3,2);	
	}

	// Update is called once per frame
	void Update () {

		TimeManager.timeValue = TimeManager.timeValue - Time.deltaTime;
		if (TimeManager.timeValue <= 0) {
			System.Threading.Thread.Sleep(5000);
			SceneManager.LoadScene ("MenuScreen");

		}



	}
}



