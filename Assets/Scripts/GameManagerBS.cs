using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerGS : MonoBehaviour {

	public GameObject CometPrefabs;
	GameObject CloneCometPrefabs;

	public void generateComet()
	{
		CloneCometPrefabs = Instantiate (CometPrefabs);
		float RandomPositionY = Random.Range (-3, 3);
		CloneCometPrefabs.transform.position = new Vector3 (9, RandomPositionY, 0);
	}
	// Use this for initialization
	void Start () {
		//generateComet ();
		InvokeRepeating("generateComet", 4.0f, 2.5f);
	}

	// Update is called once per frame
	void Update () {
		TimeManagerGL2.timeValue = TimeManagerGL2.timeValue + Time.deltaTime;
		/*if (TimeManagerGL2.timeValue >= 360) {
			System.Threading.Thread.Sleep(4000);
			SceneManager.LoadScene ("GameLevel2");

		}*/
	}
}
