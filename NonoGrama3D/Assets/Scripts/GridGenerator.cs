using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public GameObject cubePrefab;
    public float cellSize = 1f;
    public Material Solid;
    public int gridSize = 4;
    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < gridSize; x++)
        {
            for (int y = 0; y < gridSize; y++)
            {
                for (int z = 0; z < gridSize; z++)
                {
                    Vector3 position = new Vector3(x * cellSize, y * cellSize, z * cellSize);
                    GameObject cube = Instantiate(cubePrefab, position, Quaternion.identity);
                }
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Vector3 clickedPosition = hit.point;
                int x = Mathf.FloorToInt(clickedPosition.x / cellSize);
                int y = Mathf.FloorToInt(clickedPosition.y / cellSize);
                int z = Mathf.FloorToInt(clickedPosition.z / cellSize);

                if (x >= 0 && x < gridSize && y >= 0 && y < gridSize && z >= 0 && z < gridSize)
                {

                    Vector3 cubePosition = new Vector3(x * cellSize, y * cellSize, z * cellSize);
                    /*if (Physics.Raycast(cubePosition, Vector3.forward, out RaycastHit hitInfo, 0.1f))
                    {
                        if (hitInfo.collider.CompareTag("PrefabCube"))
                        {
                            Destroy(hitInfo.collider.gameObject);
                            return;
                        }
                    }*/
                    GameObject newCube = Instantiate(cubePrefab, cubePosition, Quaternion.identity);
                    newCube.GetComponent<Renderer>().material = Solid;
                }
            }
        }
    }
}
