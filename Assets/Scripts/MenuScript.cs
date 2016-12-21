using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public static bool paused=false;

    public void PressGoToGameMenu()
	{
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
        SceneManager.LoadScene(1);
    }


}
