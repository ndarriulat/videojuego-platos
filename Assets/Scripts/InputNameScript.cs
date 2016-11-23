using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputNameScript : MonoBehaviour {
    public InputField inputName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnEditEnd()
    {
        ScoreControl.control.nombreActual= inputName.text;
    }
}
