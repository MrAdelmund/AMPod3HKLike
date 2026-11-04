using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Resume();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape) && Time.timeScale == 1) {
			Time.timeScale = 0;
			GetComponent<Canvas> ().enabled = true;
		}else if(Input.GetKeyDown (KeyCode.Escape) && Time.timeScale == 0){
			Resume();
		}

	}

	public void Resume(){
		Time.timeScale = 1;
		GetComponent<Canvas> ().enabled = false;
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
	public void ReloadLevel()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

	
}
