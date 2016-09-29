using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed = 15f;

    string direccionActual = "left";

	// Use this for initialization
	void Start () {
	    
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
    }
	
}
