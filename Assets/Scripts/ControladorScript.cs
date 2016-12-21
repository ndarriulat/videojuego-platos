using UnityEngine;
using UnityEngine.UI;

public class ControladorScript : MonoBehaviour {
    public GameObject plato;
	public GameObject vino;
	public GameObject cafe;
    public GameObject cucaracha;
    Vector3 posicion;
    int contador = 0;
    public static bool playing;

    public Text myText;

    // Use this for initialization
    void Start () {
        posicion = new Vector3(0, 5);
        playing = true;
        posicion.y = 10;
        myText = GameObject.Find("PausedText").GetComponent<Text>();
        myText.color = Color.clear;
    }
	
	// Update is called once per frame
	void Update () {
        myText = GameObject.Find("PausedText").GetComponent<Text>();

        //Si el juego esta en pausa
        if (Time.timeScale == 0)
        {
            myText.color = Color.red;
        }
        else if (playing)
        {
            myText.color = Color.clear;
            contador++;
            int nroRandomico = Random.Range(100, 200);

            //cuando el contador alcanza un número entre 100 y 200 randomico, caerá un objeto, el contador incrementará uno a uno en cada update.
            if (nroRandomico < contador)
            {				
                contador = 0;

                //elegimos este rango (-9 y 7) ya que es el rango maximo que puede alcanzar el mozo
                posicion.x = Random.Range(-9, 7);
				GameObject objeto;


                //para definir qué objeto caerá
                int randomObjeto = Random.Range(1, 10);

                // si randomObjeto está entre 1 y 7, entonces caerá un plato. 70% de probabilidad. 
                // si randomObjeto es 8, entonces caerá un vino. 10% de probabilidad.
                // si randomObjeto es 9, entonces caerá un café. 10% de probabilidad.
                // si randomObjeto es 10, entonces caerá una cucaracha. 10% de probabilidad.

                if (randomObjeto > 4)
                {
                    randomObjeto = 4;
                }
                GameObject elementoQueCae = new GameObject();
                switch (randomObjeto)
                {
                    case 1: //cucaracha
                        elementoQueCae = cucaracha;
                        break;
                    case 2: //cafe
                        elementoQueCae = cafe;
                        break;
                    case 3: //vino
                        elementoQueCae = vino;
                        break;
                    case 4: //plato
                        elementoQueCae = plato;
                        break;
                    default:
                        break;
                }
                objeto = (GameObject)Instantiate(elementoQueCae, posicion, Quaternion.identity);

            }
        }
    }

    public static void stopGame()
    {
        playing = false;
    }

}
