using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    public float speed = 15f;

    public Text scoreText;
    private int score;
    // Use this for initialization
    void Start () {
        score = 0;
        UpdateScore();
	}
	
	// Update is called once per frame
	void Update () {
        float move = Input.GetAxis("Horizontal");
        if (move>0)
        {
            //CambiarDireccion("right");
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (move<0)
        {
           // CambiarDireccion("left");
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
	}

    //void CambiarDireccion(string direccion)
    //{
    //    if (direccionActual != direccion)
    //    {
    //        if (direccion == "right")
    //        {
    //            transform.Rotate(0, -180, 0);
    //            direccionActual = "right";
    //        }
    //        if (direccion == "left")
    //        {
    //            transform.Rotate(0, 180, 0);
    //            direccionActual = "left";
    //        }

    //    }
    //}

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("OnTriggerEnter");
        //collider.gameObject.SetActive(false);
        Destroy(collider.gameObject);
        AddScore(10);
    }


    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
        Debug.Log(scoreText.text);
        Debug.Log(score);
    }
	
    public void AddScore(int newScoreValue){
        score += newScoreValue;
        UpdateScore();
    }
}
