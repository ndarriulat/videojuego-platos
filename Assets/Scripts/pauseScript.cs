using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class pauseScript : MonoBehaviour {

    public bool pausedGame;
    
	// Use this for initialization
	void Start () {
        pausedGame = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pausedGame = !pausedGame;
        }
        if (pausedGame)
        {
            Time.timeScale = 0;
        }
        else if (!pausedGame)
        {
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && pausedGame)
        {
            Utilidades.EndGame(0);
        }

    }
}
