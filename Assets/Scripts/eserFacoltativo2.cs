using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class eserFacoltativo2 : MonoBehaviour
{

    public int n = 20;
    int moltiplicatore = 0;

    // Start is called before the first frame update
    void Start()
    {
        int risultato = 0;

        while (risultato < n * 10)
        {
            risultato = risultato + n;

            Debug.Log(++moltiplicatore + "x" + n + "=" + risultato);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
