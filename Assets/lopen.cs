using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player1 : MonoBehaviour
{
    private float moveSpeed1 = 10f;

    Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = new Vector3(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            forward = Camera.main.transform.forward;
            
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            forward = -Camera.main.transform.forward;
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            forward = -Camera.main.transform.right;
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            forward = Camera.main.transform.right;
            
            
        }

        

        forward.y = 0;
        forward = forward.normalized;
        //transform.position += forward * Time.deltaTime * moveSpeed1;
        rb.AddForce(transform.position * moveSpeed1);

    }
}