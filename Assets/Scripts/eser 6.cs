using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eser6 : MonoBehaviour
{

    public int a = 1;
    public int b = 10;






    void Start()
    {

        GeneraArray(a, b);
        SommaArray();


    }



    void GeneraArray(int minimo, int massimo)
    {

        int[] Array = new int[10];

        for (int i = 0; i < Array.Length; i++)
        {
            Array[i] = Random.Range(minimo, massimo);

        }

        Debug.Log(string.Join(",", Array));
    }

    void SommaArray()
    {
        int[] ArraySomma = new int[10];
        int somma = 0;

        for (int i = 0; i < ArraySomma.Length; i++)
        {
            ArraySomma[i] = Random.Range(1, 10);
            somma += ArraySomma[i];

        }
        Debug.Log(somma);

    }





}
