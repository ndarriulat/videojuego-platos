using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public static bool paused=false;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey (KeyCode.Escape)) {
			if (ControladorScript.playing) {
				Time.timeScale = 0;	
				paused = true;			
				ControladorScript.playing = false;
			} else {
				Time.timeScale = 1;
				paused=false;
				ControladorScript.playing = true;
			}
			GameEndHandler.gameEndHandler.isGameOver = false;
			//SceneManager.LoadScene(1); // vuelve al menu principal. comentado porque por ahora pausa y solo detiene el juego
		}/* else if(!paused){
			Time.timeScale = 1;
		}*/
		if (Input.GetKey (KeyCode.Return) || Input.GetKey (KeyCode.KeypadEnter)) {
			if (GameEndHandler.gameEndHandler != null) {
				GameEndHandler.gameEndHandler.isGameOver = false;
			}
			SceneManager.LoadScene (1);
		}

	}

    public void PressGoToGameMenu()
	{
//		GameEndHandler.gameEndHandler.isGameOver = false;
        SceneManager.LoadScene(1);
    }

    public void PressPlay()
    {
        SceneManager.LoadScene(2);
    }

    public void PressExit()
    {
        Application.Quit();
    }

    public void PressChangePlayer()
    {
        SceneManager.LoadScene(0);
    }

    public void PressHighScore()
    {
        SceneManager.LoadScene(3);
    }

    public void PressMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PressBack()
	{
		GameEndHandler.gameEndHandler.isGameOver = false;
        SceneManager.LoadScene(1);
    }
}
