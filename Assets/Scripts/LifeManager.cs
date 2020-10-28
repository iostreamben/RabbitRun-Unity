using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LifeManager : MonoBehaviour {

	public static int lifeValue;
	public Text LinkToLifeTextUI;


	// Use this for initialization
	void Start () {

		lifeValue = 5;
		LinkToLifeTextUI.text = "Life x " + lifeValue;
	}
	
	// Update is called once per frame
	void Update () {
		LinkToLifeTextUI.text = "Life x " + lifeValue;

	}
}
