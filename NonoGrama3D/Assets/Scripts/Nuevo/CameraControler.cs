using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public Transform target;

    private Vector3 lastMousePosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;
            transform.RotateAround(target.position, Vector3.up, delta.x * rotationSpeed);
            transform.RotateAround(target.position, transform.right, -delta.y * rotationSpeed);
            lastMousePosition = Input.mousePosition;
        }
    }
}
