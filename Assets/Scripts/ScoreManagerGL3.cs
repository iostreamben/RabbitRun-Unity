using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerGL3 : MonoBehaviour {

	public static int scoreValue;
	public Text LinkToScoreTextUI;

	void Start () {
		scoreValue = 0;
		LinkToScoreTextUI.text = "Score: " + scoreValue;
	}

	// Update is called once per frame
	void Update () {
		LinkToScoreTextUI.text = "Score: " + scoreValue;
	}
}
