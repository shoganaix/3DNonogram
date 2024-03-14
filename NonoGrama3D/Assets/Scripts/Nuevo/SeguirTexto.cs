using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirTexto : MonoBehaviour
{
    public Transform target; // Referencia al objeto (la c�mara) que se utilizar� como objetivo de orientaci�n

    void Update()
    {
        // Obt�n la direcci�n desde el objeto de texto hacia el objetivo (la c�mara)
        Vector3 targetDirection = target.position - transform.position;

        // Calcula la rotaci�n necesaria para orientar el objeto de texto hacia el objetivo
        Quaternion newRotation = Quaternion.LookRotation(targetDirection);

        // Ajusta la rotaci�n para que el objeto mire hacia la c�mara pero no de espaldas
        newRotation *= Quaternion.Euler(0, 180, 0);

        // Aplica la rotaci�n al objeto de texto
        transform.rotation = newRotation;
    }
}
