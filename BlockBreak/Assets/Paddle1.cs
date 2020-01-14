using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + Input.GetAxis("Horizontal");
        transform.position = new Vector3(Mathf.Clamp(xPos, -5.5f, 5.5f), -9.5f, 0);
    }
}
