using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;

    public float sideSpeed = 10f;

    //private float horizontalInput;

    //private float verticalInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* horizontalInput = Input.GetAxis("Horizontal");
         verticalInput = Input.GetAxis("Vertical");
         //transform.Translate(0, 0, 1);
         transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
         transform.Translate(Vector3.right * Time.deltaTime * sideSpeed * horizontalInput);
         transform.Rotate(Vector3.up, Time.deltaTime * sideSpeed * horizontalInput * 20);
         */
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * sideSpeed);
            transform.Rotate(Vector3.up, -75f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * sideSpeed);
            transform.Rotate(Vector3.up, 75f * Time.deltaTime);
        }

    }
}
