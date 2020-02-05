using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    new Rigidbody rigidbody;
    AudioSource rocketSound;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        rocketSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        Thrust();
        Rotate();
	}

    private void Thrust()
    {
        bool keySpacePressed = Input.GetKey(KeyCode.Space);

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
    }

    private void Rotate()
    {
        bool keyAPressed = Input.GetKey(KeyCode.A);
        bool keyDPressed = Input.GetKey(KeyCode.D);

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
