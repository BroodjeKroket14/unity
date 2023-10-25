using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class NewBehaviourScript : MonoBehaviour
{
    // public float horizontalSpeed = -2.0F;
    //public float verticalSpeed = 2.0F;
    //void Update()
    //{
    //float h = horizontalSpeed * Input.GetAxis("Mouse X");
    //float v = verticalSpeed * Input.GetAxis("Mouse Y");
    // transform.Rotate(v, h, 0);
    //}
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity = 15f;

    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
  