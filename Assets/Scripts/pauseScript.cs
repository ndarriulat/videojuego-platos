using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class pauseScript : MonoBehaviour {

    public bool paused;

    public bool isPaused() {
        return paused;
    }

	// Use this for initialization
	void Start () {
        paused = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            paused = !paused;
        }
        if (paused)
        {
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            Time.timeScale = 1;
        }
        if (Input.GetKeyDown(KeyCode.Escape) /*&& paused*/)
        {
            Utilidades.EndGame(0);
        }

    }
}
