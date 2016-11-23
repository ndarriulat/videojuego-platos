using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScoreControl : MonoBehaviour {

    public string nombreActual;
    private int puntajeActual;
    public List<HighScore> listaHighScores;

    public static ScoreControl control;

    public void guardarPuntajeActual(int puntaje)
    {
        puntajeActual = puntaje;
        listaHighScores.Add(new HighScore(nombreActual,puntajeActual));
    }

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(this.gameObject);
            control = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

	// Use this for initialization
	void Start () {
        // Leo de la BD los puntajes y los agrego en la lista.
        listaHighScores = new List<HighScore>();
        /////////////////////////////////////////////////////////// DESCOMENTAR:
        string nombreKey = "h";
        for (int i = 0; i < 5; i++)
        {
            string highScore = PlayerPrefs.GetString(nombreKey + (i + 1));
            string[] partes = highScore.Split(',');
            listaHighScores.Add(new HighScore(partes[0], partes[1]));
        }
        
	}
	
    void OnApplicationQuit()
    {
        // antes de guardar agrego el score a la lista y re ordeno por puntaje. me quedo con los 5 primeros
        listaHighScores.Sort((h1,h2) => h1.Puntaje.CompareTo(h2.Puntaje));
        string nombreKey = "h";
        for (int i = 0; i < 5; i++)
        {
            string highScore = PlayerPrefs.GetString(nombreKey + (i + 1));
            string[] partes = highScore.Split(',');
            listaHighScores.Add(new HighScore(partes[0], partes[1]));
            PlayerPrefs.SetString(nombreKey + (i + 1), highScore[i].ToString());
        }
        
        
        // PRUEBA:
        //PlayerPrefs.SetString("h1", new HighScore("Juan",20).ToString());
        //PlayerPrefs.SetString("h2", new HighScore("Juan", 30).ToString());
	}
}

public class HighScore
{
    public string Nombre{get;set;}
    public int Puntaje{get;set;}

    public HighScore(string nombre,int puntaje)
    {
        this.Nombre=nombre;
        this.Puntaje=puntaje;
    }

    public HighScore(string nombre, string puntaje)
    {
        this.Nombre = nombre;
        this.Puntaje = int.Parse(puntaje);
    }
    public override string ToString()
    {
 	     return Nombre+","+Puntaje;
    }
}