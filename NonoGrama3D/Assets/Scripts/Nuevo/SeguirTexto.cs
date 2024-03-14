using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirTexto : MonoBehaviour
{
    public Transform target; // Referencia al objeto (la cámara) que se utilizará como objetivo de orientación

    void Update()
    {
        // Obtén la dirección desde el objeto de texto hacia el objetivo (la cámara)
        Vector3 targetDirection = target.position - transform.position;

        // Calcula la rotación necesaria para orientar el objeto de texto hacia el objetivo
        Quaternion newRotation = Quaternion.LookRotation(targetDirection);

        // Ajusta la rotación para que el objeto mire hacia la cámara pero no de espaldas
        newRotation *= Quaternion.Euler(0, 180, 0);

        // Aplica la rotación al objeto de texto
        transform.rotation = newRotation;
    }
}
