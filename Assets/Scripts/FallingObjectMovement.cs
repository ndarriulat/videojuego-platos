using UnityEngine;
using System.Collections;

public class FallingObjectMovement : MonoBehaviour {

    public float fallSpeed = 140.0f;
	public int variacionVelocidad=0;
	public int puntos=0;

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
    }

	
}
