using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {

    public Rigidbody rb;
    public AudioSource thrust_sound;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        thrust_sound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        HandleInput();
	}

    private void HandleInput()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up);
            if (!thrust_sound.isPlaying)
            {
                thrust_sound.Play();    
            }

            print("Rocket Go up");
        }
        else
        {
            if (thrust_sound.isPlaying)
            {
                thrust_sound.Stop();
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.right);
        }


    }
}
