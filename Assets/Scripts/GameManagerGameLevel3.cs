using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManagerGameLevel3 : MonoBehaviour {

	public GameObject spiderPrefabs;
	GameObject CloneSpider;
	public GameObject[] spawnPointArray;


	public void generateMonsterAtSpawnPoint()
	{
		CloneSpider = Instantiate (spiderPrefabs);
		int spawnPointIndex = Random.Range (0, 5);
		CloneSpider.transform.position = spawnPointArray [spawnPointIndex].transform.position;
		//new vector3(0,4,0);
		Destroy(CloneSpider, 4.0f);
	}
	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("generateMonsterAtSpawnPoint",3,2);	
	}
	
	// Update is called once per frame
	void Update () {
		
		TimeManager.timeValue = TimeManager.timeValue - Time.deltaTime;
		if (TimeManager.timeValue <= 0) {
			System.Threading.Thread.Sleep(5000);
			SceneManager.LoadScene ("MenuScreen");

		}
		if (LifeManager.lifeValue >= 10000) {
			System.Threading.Thread.Sleep(5000);
			SceneManager.LoadScene ("MenuScreen");

		}

	}
}



