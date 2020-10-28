using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour {

	public static float timeValue;
	public Text LinkToTimeTextUI;

	// Use this for initialization
	void Start () {

		timeValue = 120;
		LinkToTimeTextUI.text = "Time Left: " + timeValue;
	}
	
	// Update is called once per frame
	void Update () {
		LinkToTimeTextUI.text = "Time Left: " + timeValue;


	}
}
