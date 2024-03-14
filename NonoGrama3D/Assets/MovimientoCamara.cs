using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public Transform objetivo;  // Objeto alrededor del cual se mover� la c�mara
    public float velocidadRotacion = 5.0f;

    void Update()
    {
        // Verifica si se presiona el bot�n izquierdo del mouse
        if (Input.GetMouseButton(0))
        {
            // Calcula la rotaci�n en funci�n del movimiento del mouse
            float rotX = Input.GetAxis("Mouse X") * velocidadRotacion;
            float rotY = Input.GetAxis("Mouse Y") * velocidadRotacion;

            // Aplica la rotaci�n al objeto objetivo
            objetivo.Rotate(Vector3.up, -rotX, Space.World);
            objetivo.Rotate(Vector3.right, rotY, Space.World);
        }
    }
}
