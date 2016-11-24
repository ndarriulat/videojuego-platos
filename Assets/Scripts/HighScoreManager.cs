using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class HighScoreManager : MonoBehaviour {
    public Text h1;
    public Text h2;
    public Text h3;
    public Text h4;
    public Text h5;

	// Use this for initialization
	void Start () {
        List<Text> listaTexts = new List<Text>(){h1,h2,h3,h4,h5};

		ScoreControl.control.listaHighScores.Sort((score1,score2) =>-1* score1.Puntaje.CompareTo(score2.Puntaje));
	    // leer los valores de la lista y asignarlos a los text
        for (int i = 0; i < ScoreControl.control.listaHighScores.Count; i++)
        {
            HighScore hs=ScoreControl.control.listaHighScores[i];
            listaTexts[i].text = hs.Nombre + " - "+hs.Puntaje;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
