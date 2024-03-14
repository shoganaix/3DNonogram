using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[,,] cubos = new GameObject[3, 3, 3];
    private bool isBlack = false;

    // Asigna los cubos manualmente desde el Inspector de Unity.
    public GameObject[] cubosEnEscena;

    void Start()
    {
        FillCubosArray();

    }

    void FillCubosArray()
    {
        int index = 0;
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z < 3; z++)
                {
                    // Asigna cada cubo desde el arreglo cubosEnEscena.
                    cubos[x, y, z] = cubosEnEscena[index];
                    index++;
                }
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.collider.gameObject;

                if (clickedObject != null)
                {
                    int x = Mathf.RoundToInt(clickedObject.transform.position.x);
                    int y = Mathf.RoundToInt(clickedObject.transform.position.y);
                    int z = Mathf.RoundToInt(clickedObject.transform.position.z);

                    GameObject cube = cubos[x, y, z];
                    if (cube != null)
                    {
                        MeshRenderer renderer = cube.GetComponent<MeshRenderer>();
                        isBlack = !isBlack;
                        if (isBlack)
                        {
                            renderer.material.color = Color.black;
                        }
                        else
                        {
                            renderer.material.color = Color.clear;
                        }
                    }
                }
            }
        }
    }
}