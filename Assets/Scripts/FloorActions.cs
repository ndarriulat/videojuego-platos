using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using AssemblyCSharp;

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
        if (nombreObjeto != ("Cucaracha"))
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
        if (nombreObjeto == ("Plato")) {
			ShowGameOver();			
		}
        Destroy(collider.gameObject);
    }

    void ShowGameOver()
    {
		Utilidades.EndGame(player.score);
    }

}
