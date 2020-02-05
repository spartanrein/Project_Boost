using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    new Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        bool keyAPressed = Input.GetKey(KeyCode.A);
        bool keyDPressed = Input.GetKey(KeyCode.D);
        bool keySpacePressed = Input.GetKey(KeyCode.Space);

        if (keySpacePressed)
        {
            print("Space pressed");
            rigidbody.AddRelativeForce(Vector3.up);

        }
        if (keyAPressed)
        {
            print("A is pressed");
        }
        else if (keyDPressed)
        {
            print("D is pressed");
        }
    }
}
