using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntosUI : MonoBehaviour
{
    public Text puntosText;
    public int puntosNecesarios;

    void Update()
    {
        // Actualiza el texto en la UI con la cantidad de puntos necesarios
        puntosText.text = "Puntos necesarios: " + puntosNecesarios.ToString();
    }
}
