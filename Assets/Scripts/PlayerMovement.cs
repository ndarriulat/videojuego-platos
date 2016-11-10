using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour {

    public float speed = 15f;
	public const int variacionVelocidadVino=-7;
	public const int variacionVelocidadCafe=7;
	public const float normalSpeed=15f;
	// Velocidades Maxima y Minima
	public float minimumSpeed = normalSpeed + variacionVelocidadVino;
	public float maximumSpeed = normalSpeed + variacionVelocidadCafe;
    public float tiempoPowerUp = 3;
    public float tiempoAcumulado = 0;

    public Text scoreText;
	private int score;
	public Dictionary<string,int> scoreVariations=new Dictionary<string,int>();
	public Dictionary<string,int> speedVariations=new Dictionary<string,int>();
	string nombrePlato = "Plato(Clone)";
	string nombreVino = "Vino(Clone)";
	string nombreCafe = "Cafe(Clone)";

	private Rigidbody rigid;

    // Use this for initialization
    void Start () {
        score = 0;
		UpdateScore();
		scoreVariations.Add (nombrePlato, 10);
		scoreVariations.Add (nombreVino, 0);
		scoreVariations.Add (nombreCafe, 0);

		speedVariations.Add (nombrePlato, 0);
		speedVariations.Add (nombreVino, variacionVelocidadVino);
		speedVariations.Add (nombreCafe, variacionVelocidadCafe);

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
        if (speed!=normalSpeed)
        {
            tiempoAcumulado += Time.deltaTime;
            if (tiempoAcumulado>=tiempoPowerUp)
            {
                speed = normalSpeed;
                tiempoAcumulado = 0;
            }
        }
    }

    void OnTriggerEnter(Collider collider)
    {
		string colliderObjectName = collider.gameObject.name;
		if (!colliderObjectName.Contains("Pared")) {
			Destroy(collider.gameObject);
			UpdatePlayerAttributes (colliderObjectName);			
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
//		Debug.Log ("Speed: " + speed);
	}

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;

    }
	
    public void AddScore(int newScoreValue){
        score += newScoreValue;
        UpdateScore();
    }
}
