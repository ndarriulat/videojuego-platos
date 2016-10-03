using UnityEngine;
using System.Collections;
using UnityEditor; 
//pruebis
public class ControladorScript : MonoBehaviour {
    public GameObject plato;
    Vector3 posicion;
    int contador = 0;
    
	// Use this for initialization
	void Start () {
        posicion = new Vector3(0, 5);
        ////GameObject objeto =(GameObject) PrefabUtility.CreateEmptyPrefab("Assets/FallingObject.prefab");
        //GameObject objeto = (GameObject)Instantiate(plato, pos1.transform.position, Quaternion.identity);
        //objeto.transform.position = new Vector2(100, 300);
        //objeto.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        //if
        //float timeRandom = Random.Range(1, 3);
        contador++;
        int nroRandomico = Random.Range(100, 200);
        if (nroRandomico < contador)
        {
        //if (contador == 100)
        //{
            Debug.Log(contador);
            contador = 0;
            posicion.x = Random.Range(-9, 9);
            GameObject objeto = (GameObject)Instantiate(plato, posicion, Quaternion.identity);
            
        }
	}
    
}
