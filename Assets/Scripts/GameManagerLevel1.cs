using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManagerLevel1 : MonoBehaviour {

	public GameObject GreenOrbPrefabs;

	GameObject CloneOrb;
	public GameObject[] spawnPointArray;


	public void generateOrbAtSpawnPoint()
	{
		CloneOrb = Instantiate (GreenOrbPrefabs);
		int spawnPointIndex = Random.Range (0, 5);
		CloneOrb.transform.position = spawnPointArray [spawnPointIndex].transform.position;
		//new vector3(0,4,0);
		Destroy(CloneOrb, 4.0f);

	}
	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("generateOrbAtSpawnPoint",3,2);	
	}

	// Update is called once per frame
	void Update () {

		TimeManager.timeValue = TimeManager.timeValue - Time.deltaTime;
		if ((TimeManager.timeValue <= 0) & (ScoreManager.scoreValue <= 25)) {
			System.Threading.Thread.Sleep(4000);
			SceneManager.LoadScene ("GameOver");

		}
		 if (ScoreManagerGL1.scoreValue >= 25) {
			System.Threading.Thread.Sleep (3000);
			SceneManager.LoadScene ("NextLevel");

		}


	}
}



