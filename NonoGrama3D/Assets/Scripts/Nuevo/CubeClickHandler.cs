using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeClickHandler : MonoBehaviour
{
    public Vector3 cubeNumber;
    public Material MaterialAcierto; 
    public Material MaterialPerdido;
    public GameManager2 gamemanager;
    private bool acertado;

    private Material originalMaterial; 

    void Start()
    {
        originalMaterial = GetComponent<Renderer>().material; // Guarda el material original del cubo
    }

    void OnMouseDown()
    {
        Debug.Log("Cubo " + cubeNumber.x + " - " + cubeNumber.y + " - " + cubeNumber.z + " clickeado");
         
        for (int i = 0; i < gamemanager.PuzzleResuelto.Length; i++)
        {
            if (gamemanager.PuzzleResuelto[i] == cubeNumber)
            {
                gamemanager.puntos++;
                acertado = true;
                gamemanager.PuzzleResuelto[i] = new Vector3(4,4,4);
            }
        }
        if (acertado == true)
        {
            GetComponent<Renderer>().material = MaterialAcierto;
        }
        else { GetComponent<Renderer>().material = MaterialPerdido; }

        gamemanager.Ganar();


    }

}
