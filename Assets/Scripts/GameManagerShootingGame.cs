using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerShootingGame : MonoBehaviour {
	public GameObject spiderPrefabs;
	GameObject CloneSpider;
	public GameObject[] spawnPointArray;


	public void generateMonsterAtSpawnPoint()
	{
		CloneSpider = Instantiate (spiderPrefabs);
		int spawnPointIndex = Random.Range (0, 5);
		CloneSpider.transform.position = spawnPointArray [spawnPointIndex].transform.position;
		CloneSpider.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;
		CloneSpider.GetComponent<Rigidbody2D> ().AddForce (Vector2.left * 250);
		//new vector3(0,4,0);
		Destroy(CloneSpider, 4.0f);
	}

	// Use this for initialization
	void Start () {
		InvokeRepeating ("generateMonsterAtSpawnPoint",3,2);	

	}
	
	// Update is called once per frame
	void Update () {
		TimeManagerGL3.timeValue = TimeManagerGL3.timeValue + Time.deltaTime;
		if (TimeManagerGL3.timeValue >= 180) {
			System.Threading.Thread.Sleep(3000);
			SceneManager.LoadScene ("GameShooting");

		}

	}
}
