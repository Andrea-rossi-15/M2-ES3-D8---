using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PROVA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int elefante = 1;
        for (elefante = 1; elefante <= 10; elefante++)
        {
            if (elefante % 2 == 0)
            {
                Debug.Log(elefante + " elefante si dondolava sopra il filo di una ragnatela" + " pari");
            }
            else if (elefante % 2 != 0)
            {
                Debug.Log(elefante + " elefante si dondolava sopra il filo di una ragnatela" + " dispari");
            }

        }
    }


}
