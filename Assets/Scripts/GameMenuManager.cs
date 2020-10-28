using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour 
{
	public void gotoHowToPlayScreen()
	{

		SceneManager.LoadScene("HowToPlayScreen");
	}
	public void gotoOptions()
	{
		SceneManager.LoadScene("OptionScreen");
	}
	public void gotoCredit()
	{
		SceneManager.LoadScene("CreditScreen");
	}
	public void backToGameMenu()
	{
		SceneManager.LoadScene("MenuScreen");
	}

	public void startGame()
	{
		SceneManager.LoadScene("GameLevel1Screen");
	}

}


