using UnityEngine;
using System.Collections;
using UnityEditor; 

public class ControladorScript : MonoBehaviour {
    public GameObject plato;
	public GameObject vino;
	public GameObject cafe;
    Vector3 posicion;
    int contador = 0;
    public static bool playing;
    
	// Use this for initialization
	void Start () {
        posicion = new Vector3(0, 5);
        playing = true;
        ////GameObject objeto =(GameObject) PrefabUtility.CreateEmptyPrefab("Assets/FallingObject.prefab");
        //GameObject objeto = (GameObject)Instantiate(plato, pos1.transform.position, Quaternion.identity);
        //objeto.transform.position = new Vector2(100, 300);
        //objeto.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        //if
        //float timeRandom = Random.Range(1, 3);
        if (playing)
        {
            contador++;
            int nroRandomico = Random.Range(100, 200);
            if (nroRandomico < contador)
            {
                //Debug.Log(contador);
                contador = 0;
                posicion.x = Random.Range(-9, 9);
				GameObject objeto;
				if (nroRandomico % 2 == 0) {
					objeto = (GameObject)Instantiate (plato, posicion, Quaternion.identity);
				} 
				if(nroRandomico%3==0) {
					objeto = (GameObject)Instantiate (vino, posicion, Quaternion.identity);
				}
				if (nroRandomico%7==0) {
					objeto = (GameObject)Instantiate (cafe, posicion, Quaternion.identity);
				}
            }
        }
    }

    public static void stopGame()
    {
        playing = false;
    }

}
