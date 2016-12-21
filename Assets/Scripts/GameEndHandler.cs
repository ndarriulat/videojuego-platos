using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameEndHandler : MonoBehaviour {

	public static GameEndHandler gameEndHandler;
	public bool isGameOver;

    public Text myText;

    // Use this for initialization
    void Start () {

	}


	void Update()
    {
        if (ScoreControl.control.ObtenerPuntajeActual() > 0)
        {
            myText = GameObject.Find("Text_PuntajeFinal").GetComponent<Text>();
            myText.color = Color.white;
            myText.text = "Tu puntaje es " + ScoreControl.control.ObtenerPuntajeActual();
        }
        else {
            myText = GameObject.Find("Text_PuntajeFinal").GetComponent<Text>();
            myText.color = Color.clear;
            myText.text = "";
        }
    }

	void Awake()
	{
		if (gameEndHandler == null)
		{
			DontDestroyOnLoad(this.gameObject);
			gameEndHandler = this;
		}
        else if (gameEndHandler!=this)
		{
			Destroy(this.gameObject);
		}

	}
}
