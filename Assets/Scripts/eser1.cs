using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using UnityEngine;

public class eser1 : MonoBehaviour
{

    int index = 10;

    int num = 10;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        while (index > 0)
        {
            ++num;
            Debug.Log(num);

            --index;
            Debug.Log(index);
        }

    }




}


