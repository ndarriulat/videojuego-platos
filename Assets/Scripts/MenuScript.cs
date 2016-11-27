using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {


	// Update is called once per frame
	void Update()
	{

		if (Input.GetKey(KeyCode.Escape))
		{
			GameEndHandler.gameEndHandler.isGameOver = false;
			SceneManager.LoadScene(1);
		}
		if (Input.GetKey(KeyCode.KeypadEnter))
		{
			GameEndHandler.gameEndHandler.isGameOver = false;
			SceneManager.LoadScene(1);
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
