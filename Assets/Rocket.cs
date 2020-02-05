using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    [SerializeField] float rcsThrust = 100f;
    [SerializeField] float mainThrust = 100f;
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
            rigidbody.AddRelativeForce(Vector3.up * mainThrust);
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

        rigidbody.freezeRotation = true;

        float rotationThisFrame = rcsThrust * Time.deltaTime;

        if (keyAPressed)
        {
            print("A is pressed");
            transform.Rotate(Vector3.forward * rotationThisFrame);
        }
        else if (keyDPressed)
        {
            print("D is pressed");
            transform.Rotate(-Vector3.forward * rotationThisFrame);
        }

        rigidbody.freezeRotation = false;
    }
}
