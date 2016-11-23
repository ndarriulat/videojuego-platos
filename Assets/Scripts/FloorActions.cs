using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FloorActions : MonoBehaviour {

    GameObject[] finishObjects;
    public PlayerMovement player;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider)
    {
		string nombreObjeto=collider.gameObject.tag;
		if (nombreObjeto == ("Plato")) {
			ShowGameOver();			
		}
        Destroy(collider.gameObject);
    }

    void ShowGameOver()
    {
        ScoreControl.control.guardarPuntajeActual(player.score);
        SceneManager.LoadScene(1);
    }

}
