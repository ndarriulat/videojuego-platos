using UnityEngine;
using System.Collections;
using UnityEditor; 

public class ControladorScript : MonoBehaviour {
    public GameObject plato;
	public GameObject vino;
	public GameObject cafe;
    public GameObject cucaracha;
    Vector3 posicion;
    int contador = 0;
    public static bool playing;
    
	// Use this for initialization
	void Start () {
        posicion = new Vector3(0, 5);
        playing = true;
    }
	
	// Update is called once per frame
	void Update () {
		
        if (playing)
        {
            contador++;
            int nroRandomico = Random.Range(100, 200);
            if (nroRandomico < contador)
            {				
                contador = 0;
                posicion.x = Random.Range(-9, 9);
				GameObject objeto;
                
                if (nroRandomico % 2 == 0) {
					objeto = (GameObject)Instantiate (plato, posicion, Quaternion.identity);
				} else {
					if (nroRandomico % 10 < 5) {
						objeto = (GameObject)Instantiate (vino, posicion, Quaternion.identity);						
					} else if ((nroRandomico % 10) >= 5 && (nroRandomico %10)< 8) {

						objeto = (GameObject)Instantiate (cafe, posicion, Quaternion.identity);
					} else {
                        objeto = (GameObject)Instantiate(cucaracha, posicion, Quaternion.identity);
                    }
				}
            }
        }
    }

    public static void stopGame()
    {
        playing = false;
    }

}
