using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class eserFacoltativo3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        for (int n = 1; n <= 10; n++)
        {
            Debug.Log("tbellina del " + n);

            for (int i = 0; i < 10; i++)
            {
                Debug.Log((1 + i) * n);
            }
        }


    }

}








