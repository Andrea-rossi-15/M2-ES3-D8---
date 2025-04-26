using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class eserFacoltativo4 : MonoBehaviour
{

    public int n = 5;
    public int m = 8;
    int risultato = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tabellina del " + n);

        while (risultato < n * 10)

        {

            Debug.Log(risultato = risultato + 5);

        }

        Debug.Log("Tabellina " + m);
        risultato = 0;
        while (risultato < m * 10)
        {

            Debug.Log(risultato = risultato + 8);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
