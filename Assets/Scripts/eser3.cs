using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class eser3 : MonoBehaviour
{


    public int numero;

    void Start()
    {

        for (numero = 1; numero <= 30; numero++)
        {

            if (numero % 5 == 0 && numero % 3 == 0)
            {
                Debug.Log("FizzBuzz");
            }

            else if (numero % 3 == 0)
            {
                Debug.Log("Fizz");

            }

            else if (numero % 5 == 0)
            {
                Debug.Log("Buzz");
            }



            else if (numero % 5 != 0 && numero % 3 != 0)
            {
                Debug.Log(numero);
            }

        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
