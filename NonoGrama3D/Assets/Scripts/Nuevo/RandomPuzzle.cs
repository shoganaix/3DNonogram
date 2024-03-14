using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPuzzle : MonoBehaviour
{
    public GameManager2 gamemanager;
    private System.Random rnd = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        GenerarPuzzle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void GenerarPuzzle()
    {
        
        int numeroAleatorio = rnd.Next(0, 4);
        for (int i = 0; i < 4; i++)
        {
            gamemanager.PuzzleResuelto[i].x = rnd.Next(0, 3);
            gamemanager.PuzzleResuelto[i].y = rnd.Next(0, 3);
            gamemanager.PuzzleResuelto[i].z = rnd.Next(0, 3);
        }
    }
}
