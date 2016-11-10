using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public void PressPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void PressExit()
    {
        SceneManager.LoadScene(0);
    }

    public void PressHighScore()
    {
        SceneManager.LoadScene(2);
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
