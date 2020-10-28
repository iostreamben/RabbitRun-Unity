using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManagerGL3 : MonoBehaviour {

	public static float timeValue;
	public Text LinkToTimeTextUI;

	// Use this for initialization
	void Start () {

		timeValue = 0;
		LinkToTimeTextUI.text = "Time: " + timeValue;
	}

	// Update is called once per frame
	void Update () {
		LinkToTimeTextUI.text = "Time: " + timeValue;


	}
}
