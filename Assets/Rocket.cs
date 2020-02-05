using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    new Rigidbody rigidbody;
    AudioSource rocketSound;
    bool playRocketSound;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        rocketSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        bool keyAPressed = Input.GetKey(KeyCode.A);
        bool keyDPressed = Input.GetKey(KeyCode.D);
        bool keySpacePressed = Input.GetKey(KeyCode.L);

        if (keySpacePressed)
        {
            print("Space pressed");
            rigidbody.AddRelativeForce(Vector3.up);
            if (!rocketSound.isPlaying)
            {
                rocketSound.Play();
            }
        }
        else
        {
            rocketSound.Stop();
        }
        if (keyAPressed)
        {
            print("A is pressed");
            transform.Rotate(Vector3.forward);
        }
        else if (keyDPressed)
        {
            print("D is pressed");
            transform.Rotate(-Vector3.forward);
        }
    }
}
