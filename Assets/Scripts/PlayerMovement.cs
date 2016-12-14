using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using AssemblyCSharp;

public class PlayerMovement : MonoBehaviour {

    public float speed = 15f;
	public const int variacionVelocidadVino=-7;
	public const int variacionVelocidadCafe=7;
	public const float normalSpeed=15f;
	// Velocidades Maxima y Minima
	public float minimumSpeed = normalSpeed + variacionVelocidadVino;
	public float maximumSpeed = normalSpeed + variacionVelocidadCafe;
    public float tiempoPowerUp;
    public float tiempoAcumulado = 0;

    public Text scoreText;
	public Text nameText;
	public int score;
	public Dictionary<string,int> scoreVariations=new Dictionary<string,int>();
	public Dictionary<string,int> speedVariations=new Dictionary<string,int>();
	string nombrePlato = "Plato(Clone)";
	string nombreVino = "Vino(Clone)";
	string nombreCafe = "Cafe(Clone)";

    GameObject[] finishObjects;

    private Rigidbody rigid;

    // Use this for initialization
    void Start () {
        score = 0;
		tiempoPowerUp = 8;
		//nameText.text = ScoreControl.control.nombreActual;
		UpdateScore();
		scoreVariations.Add(nombrePlato, 10);
		scoreVariations.Add(nombreVino, 0);
		scoreVariations.Add(nombreCafe, 0);

		speedVariations.Add(nombrePlato, 0);
		speedVariations.Add(nombreVino, variacionVelocidadVino);
		speedVariations.Add(nombreCafe, variacionVelocidadCafe);

		rigid = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("left"))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        //Debug.Log(tiempoAcumulado);
        if (speed!=normalSpeed)
        {
            tiempoAcumulado += Time.deltaTime;
            if (tiempoAcumulado>=tiempoPowerUp)
            {
				Debug.Log ("Tiempo: " +tiempoAcumulado+" Velocidad: "+speed+" Tiempo acumulado:" + tiempoPowerUp);
                speed = normalSpeed;
                tiempoAcumulado = 0;
            }
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        string colliderObjectName = collider.gameObject.name;
        if (colliderObjectName.Contains("Plato"))
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
        if (colliderObjectName.Contains("Cucaracha"))
        {
			Utilidades.EndGame (score);
        }        
        else {
            if (!colliderObjectName.Contains("Pared")) {
                Destroy(collider.gameObject);
			    UpdatePlayerAttributes (colliderObjectName);
                
            }
        }
    }
    


    void UpdatePlayerAttributes(string fallingObjectName)
	{
		AddScore(scoreVariations[fallingObjectName]);
		ChangePlayerSpeed (speedVariations [fallingObjectName]);
	}

	void ChangePlayerSpeed(int speedVariation)
	{
		if ((speedVariation > 0 && speed <= normalSpeed)||(speedVariation < 0 && speed >= normalSpeed)) 
		{
			speed += speedVariation;
		}
	}

    void UpdateScore()
    {
		scoreText.text = "Score: " + score;
		speed = speed + (float) 0.01;
    }
	
    public void AddScore(int newScoreValue){
        score += newScoreValue;
        UpdateScore();
    }
}
