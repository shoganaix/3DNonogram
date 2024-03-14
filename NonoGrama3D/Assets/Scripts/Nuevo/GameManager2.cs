using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public TMP_Text puntosText;
    public TMP_Text Tutorial1;
    public Image pastilla1;

    public TMP_Text Tutorial2;
    public Image pastilla2;

    public TMP_Text Tutorial3;
    public Image pastilla3;

    public TMP_Text Tutorial4;
    public Image pastilla4;

    public TMP_Text TxTAciertosEnX0;
    public TMP_Text TxTAciertosEnX1;
    public TMP_Text TxTAciertosEnX2;

    public TMP_Text TxTAciertosEnY0;
    public TMP_Text TxTAciertosEnY1;
    public TMP_Text TxTAciertosEnY2;

    public TMP_Text TxTAciertosEnZ0;
    public TMP_Text TxTAciertosEnZ1;
    public TMP_Text TxTAciertosEnZ2;
    /// <summary>
    /// //////////////////////////////////////
    /// </summary>
    /// 
    [System.Serializable]
    public class PruebaDeAciertos
    {
        public int AciertosEn00Z;
        public int AciertosEn10Z;
        public int AciertosEn20Z;
        public int AciertosEn01Z;
        public int AciertosEn02Z;
        public int AciertosEn11Z;
        public int AciertosEn12Z;
        public int AciertosEn21Z;
        public int AciertosEn22Z;

        public TMP_Text TxTAciertosEn00Z;
        public TMP_Text TxTAciertosEn10Z;
        public TMP_Text TxTAciertosEn20Z;
        public TMP_Text TxTAciertosEn01Z;
        public TMP_Text TxTAciertosEn02Z;
        public TMP_Text TxTAciertosEn11Z;
        public TMP_Text TxTAciertosEn12Z;
        public TMP_Text TxTAciertosEn21Z;
        public TMP_Text TxTAciertosEn22Z;
    }
    [SerializeField]
    private PruebaDeAciertos pruebaDeAciertos;


    

    /// <summary>
    /// ////////////////////////////////////
    /// </summary>

    public Vector3[] PuzzleResuelto;
    public int puntos = 0;
    public int puntosnecesarios;

    public int AciertosEnX0;
    public int AciertosEnX1;
    public int AciertosEnX2;

    public int AciertosEnY0;
    public int AciertosEnY1;
    public int AciertosEnY2;

    public int AciertosEnZ0;
    public int AciertosEnZ1;
    public int AciertosEnZ2;



    // Start is called before the first frame update
    void Start()
    {
        Invoke("VerDondeEstanLosCubos", 1f);
        
        
    }

    // Update is called once per frame
    void Update()
    {

        PonerTexto();

        
    
    }

   

    public void Ganar()
    {
        if (puntos >= puntosnecesarios)
        {
            Debug.Log("Ganaste");
            CambiarEscena("Ganaste");
        }
        
    }

    public void CambiarEscena(string nombreEscena) 
    {
        SceneManager.LoadScene(nombreEscena);
    }
    
    public void VerDondeEstanLosCubos()
    {
        for (int i = 0; i < PuzzleResuelto.Length; i++)
        {
            if (PuzzleResuelto[i].z == 0)
            {
                AciertosEnZ0++;
            }
            if (PuzzleResuelto[i].z == 1)
            {
                AciertosEnZ1++;
            }
            if (PuzzleResuelto[i].z == 2)
            {
                AciertosEnZ2++;
            }

        }

        for (int i = 0; i < PuzzleResuelto.Length; i++)
        {
            if (PuzzleResuelto[i].x == 0)
            {
                AciertosEnX0++;
            }
            if (PuzzleResuelto[i].x == 1)
            {
                AciertosEnX1++;
            }
            if (PuzzleResuelto[i].x == 2)
            {
                AciertosEnX2++;
            }

        }
        for (int i = 0; i < PuzzleResuelto.Length; i++)
        {
            if (PuzzleResuelto[i].y == 0)
            {
                AciertosEnY0++;
            }
            if (PuzzleResuelto[i].y == 1)
            {
                AciertosEnY1++;
            }
            if (PuzzleResuelto[i].y == 2)
            {
                AciertosEnY2++;
                
            }

        }

        /////////////////////////////////////////////////////
        for (int i = 0; i < PuzzleResuelto.Length; i++)
        {
            for (int v = 0; v < PuzzleResuelto.Length; v++)
            {
                if (PuzzleResuelto[i].x == 0 && PuzzleResuelto[i].y == 0 && PuzzleResuelto[i].z == v)
                {
                    pruebaDeAciertos.AciertosEn00Z++;
                }
                else if (PuzzleResuelto[i].x == 1 && PuzzleResuelto[i].y == 0 && PuzzleResuelto[i].z == v)
                {
                    pruebaDeAciertos.AciertosEn10Z++;

                }
                else if (PuzzleResuelto[i].x == 0 && PuzzleResuelto[i].y == 1 && PuzzleResuelto[i].z == v)
                {
                    pruebaDeAciertos.AciertosEn01Z++;

                }

                else if (PuzzleResuelto[i].x == 1 && PuzzleResuelto[i].y == 1 && PuzzleResuelto[i].z == v)
                {
                    pruebaDeAciertos.AciertosEn11Z++;

                }


                else if (PuzzleResuelto[i].x == 1 && PuzzleResuelto[i].y == 2 && PuzzleResuelto[i].z == v)
                {
                    pruebaDeAciertos.AciertosEn12Z++;

                }

                else if (PuzzleResuelto[i].x == 2 && PuzzleResuelto[i].y == 1 && PuzzleResuelto[i].z == v)
                {
                    pruebaDeAciertos.AciertosEn21Z++;

                }


                else if (PuzzleResuelto[i].x == 2 && PuzzleResuelto[i].y == 0 && PuzzleResuelto[i].z == v)
                {
                    pruebaDeAciertos.AciertosEn20Z++;

                }



                else if (PuzzleResuelto[i].x == 0 && PuzzleResuelto[i].y == 2 && PuzzleResuelto[i].z == v)
                {
                    pruebaDeAciertos.AciertosEn02Z++;

                }


                else if (PuzzleResuelto[i].x == 2 && PuzzleResuelto[i].y == 2 && PuzzleResuelto[i].z == v)
                {
                    pruebaDeAciertos.AciertosEn22Z++;

                }
            }


          
            
        }
        /////////////////////////////////////////////////////






    }
    public void PonerTexto()
    {
        TxTAciertosEnZ0.text = AciertosEnZ0.ToString();
        TxTAciertosEnZ1.text = AciertosEnZ1.ToString();
        TxTAciertosEnZ2.text = AciertosEnZ2.ToString();

        TxTAciertosEnX0.text = AciertosEnX0.ToString();
        TxTAciertosEnX1.text = AciertosEnX1.ToString();
        TxTAciertosEnX2.text = AciertosEnX2.ToString();

        TxTAciertosEnY0.text = AciertosEnY0.ToString();
        TxTAciertosEnY1.text = AciertosEnY1.ToString();
        TxTAciertosEnY2.text = AciertosEnY2.ToString();




        /////////////////////////////////////////////////////////////////////////////
        pruebaDeAciertos.TxTAciertosEn00Z.text = pruebaDeAciertos.AciertosEn00Z.ToString();
        pruebaDeAciertos.TxTAciertosEn10Z.text = pruebaDeAciertos.AciertosEn10Z.ToString();
        pruebaDeAciertos.TxTAciertosEn20Z.text = pruebaDeAciertos.AciertosEn20Z.ToString();
        pruebaDeAciertos.TxTAciertosEn01Z.text = pruebaDeAciertos.AciertosEn01Z.ToString();
        pruebaDeAciertos.TxTAciertosEn02Z.text = pruebaDeAciertos.AciertosEn02Z.ToString();
        pruebaDeAciertos.TxTAciertosEn11Z.text = pruebaDeAciertos.AciertosEn11Z.ToString();
        pruebaDeAciertos.TxTAciertosEn12Z.text = pruebaDeAciertos.AciertosEn12Z.ToString();
        pruebaDeAciertos.TxTAciertosEn21Z.text = pruebaDeAciertos.AciertosEn21Z.ToString();
        pruebaDeAciertos.TxTAciertosEn22Z.text = pruebaDeAciertos.AciertosEn22Z.ToString();

        ////////////////////////////////////////////////////////////////////////////

        puntosnecesarios = PuzzleResuelto.Length;
        puntosText.text = puntos.ToString() + " / " + puntosnecesarios.ToString();
        if (PuzzleResuelto[0] == new Vector3(4, 4, 4))
        {
            Tutorial1.text = "<color=yellow>Acertado!</color>";
            pastilla1.gameObject.SetActive(false);

        }
        else if (
          PuzzleResuelto.Length >= 1
          ) { Tutorial1.text = PuzzleResuelto[0].x.ToString() + " - " + PuzzleResuelto[0].y.ToString() + " - " + PuzzleResuelto[0].z.ToString(); }
        else { Tutorial1.text = ""; }




        if (PuzzleResuelto[1] == new Vector3(4, 4, 4))
        {
            Tutorial2.text = "<color=yellow>Acertado!</color>";
            pastilla2.gameObject.SetActive(false);
        }
        else if (PuzzleResuelto.Length >= 2) { Tutorial2.text = PuzzleResuelto[1].x.ToString() + " - " + PuzzleResuelto[1].y.ToString() + " - " + PuzzleResuelto[1].z.ToString(); }
        else { Tutorial2.text = ""; }





        if (PuzzleResuelto[2] == new Vector3(4, 4, 4))
        {
            Tutorial3.text = "<color=yellow>Acertado!</color>";
            pastilla3.gameObject.SetActive(false);
        }
        else if (PuzzleResuelto.Length >= 3) { Tutorial3.text = PuzzleResuelto[2].x.ToString() + " - " + PuzzleResuelto[2].y.ToString() + " - " + PuzzleResuelto[2].z.ToString(); }
        else { Tutorial3.text = ""; }





        if (PuzzleResuelto[3] == new Vector3(4, 4, 4))
        {
            Tutorial4.text = "<color=yellow>Acertado!</color>";

            pastilla4.gameObject.SetActive(false);
        }
        else if (PuzzleResuelto.Length >= 4) { Tutorial4.text = PuzzleResuelto[3].x.ToString() + " - " + PuzzleResuelto[3].y.ToString() + " - " + PuzzleResuelto[3].z.ToString(); }
        else { Tutorial4.text = ""; }

    }

}
