using UnityEngine;
using System.Collections;

public class FallingObjectMovement : MonoBehaviour {

    public float fallSpeed = 8.0f;

    void Update()
    {


        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);

    }

	// Use this for initialization
	void Start () {
	
	}

    //void OnTriggerEnter(Collider collider)
    //{
    //    Debug.Log("OnTriggerEnter");
    //    gameObject.SetActive(false);
    //    this.enabled = false;
    //}
	
}
