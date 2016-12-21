using UnityEngine;
using System.Collections;

public class FallingObjectMovement : MonoBehaviour {

    public float fallSpeed = 70.0f;
	public int variacionVelocidad=0;
	public int puntos=0;

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);

        //Para darle efecto de aceleracion a los objetos que caen
        fallSpeed += (float)0.1;
    }

	
}
