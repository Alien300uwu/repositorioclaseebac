using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios_De_Ciclos_y_Arreglos : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        //Ejercicio 1 
        bool Juntadoinador = true;
        int a;
        int b;

        do
        {
            int[] arre_1 = new int[Random.Range(0, 10)];
            int[] arre_2 = new int[Random.Range(0, 10)];

            a = arre_1.Length;
            b = arre_2.Length;

            int[] arre_3 = new int[(a + b)];

            Debug.Log(arre_3.Length);
            //Debug.Log(a);
            //Debug.Log(b);
            Juntadoinador = false;
        } while (Juntadoinador);




        //Ejercicio 2 ------------------------------------------------------------------------
        string[] oracion = new string[6] { "El", "secreto", "de", "avanzar", "es", "comenzar" };
        string[] uno = new string[1];
        foreach (string palabra in uno)
        {
            string union = $"{oracion[0]} " + $"{oracion[1]} " + $"{oracion[2]} " + $"{oracion[3]} " + $"{oracion[4]} " + $"{oracion[5]}";
            Debug.Log(union);
        }


        //Ejercicio 3 ------------------------------------------------------------------------
        int[,] bidimencional = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[] unidimensional = new int[3] { 3, 2, 1 };



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
