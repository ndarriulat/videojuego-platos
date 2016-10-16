using UnityEngine;
using System.Collections;

public class FloorActions : MonoBehaviour {

    GameObject[] finishObjects;
    // Use this for initialization
    void Start () {
        HideGameOver();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("GAME OVER");
        ShowGameOver();
        Destroy(collider.gameObject);
    }

    void ShowGameOver()
    {

        //se agregó un tag showOnGameOver al texto gameover
        foreach (GameObject g in finishObjects)
        {
            g.SetActive(true);
        }
        ControladorScript.stopGame();
    }
    void HideGameOver()
    {
        //se agregó un tag showOnGameOver al texto gameover
        finishObjects = GameObject.FindGameObjectsWithTag("showOnGameOver");
        foreach (GameObject g in finishObjects)
        {
            g.SetActive(false);
        }
    }
}
