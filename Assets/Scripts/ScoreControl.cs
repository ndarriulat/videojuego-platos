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

	public int ObtenerPuntajeActual()
	{
		return puntajeActual;
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
        string nombreKey = "h";
		for (int i = 0; i < 5; i++)
		{
			int indiceKey=i+1;
			nombreKey = nombreKey + indiceKey;
            string highScore = PlayerPrefs.GetString(nombreKey);
			if (highScore!="") {
				string[] partes = highScore.Split(',');
				listaHighScores.Add(new HighScore(partes[0], partes[1]));
			}
        }
        
	}
	
    void OnApplicationQuit()
    {
		listaHighScores.Sort((h1,h2) =>-1* h1.Puntaje.CompareTo(h2.Puntaje));
        string nombreKey = "h";
		for (int i = 0; i < 5 && i<listaHighScores.Count; i++)
        {
			string highScore = listaHighScores[i].ToString();
			int indiceKey=i+1;
			nombreKey = nombreKey + indiceKey;
			PlayerPrefs.SetString(nombreKey, highScore);
        }
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