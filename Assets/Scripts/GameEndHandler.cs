using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameEndHandler : MonoBehaviour {

	public static GameEndHandler gameEndHandler;
	public bool isGameOver;
	public Text gameOverText;
	public Text finalScoreText;

	// Use this for initialization
	void Start () {
		gameOverText.text = "";
		finalScoreText.text = "";
		isGameOver = false;
	}


	void Update(){

		if (gameOverText!=null&&finalScoreText!=null) {

			finalScoreText.text=ScoreControl.control.ObtenerPuntajeActual()+" puntos.";
			if (isGameOver) {
				//gameOverText.text = "Fin del juego";
				finalScoreText.text=ScoreControl.control.ObtenerPuntajeActual()+" puntos.";
			} else {
				gameOverText.text = "";
				finalScoreText.text = "";
			}			
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
