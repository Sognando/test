using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    Rigidbody rb;
    int ballSpeed = 1000;
    bool ballInPlay = false;

    // Start is called before the first frame update
    void Start()
   {
        rb =GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && ballInPlay == false) {
            transform.parent = null;
            ballInPlay = true;
            rb.AddForce(ballSpeed, ballSpeed, 0);
        }
    }
}
