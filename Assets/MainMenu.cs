using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame(){
		SceneManager.LoadScene("Level 1");   //name scene
	}

	public void HowToplay(){
		SceneManager.LoadScene("HowToPlay");  //name scene
	}

	public void QuitGame(){
		Debug.Log ("It Quit");  //Check Quit
		Application.Quit ();
	}

	public void BackGame(){
		SceneManager.LoadScene("MainManu");   //name scene
	}

}
