using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class eser5 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        {
            int find = Random.Range(1, 5);


            int[] arr = new int[6];
            {
                arr[0] = 1;
                arr[1] = 2;
                arr[2] = 3;
                arr[3] = 4;
                arr[4] = 5;
                arr[5] = 6;





                for (int i = 0; i < arr.Length; i++)
                {


                    if (arr[i] == find)
                    {
                        Debug.Log(arr[i] + " found");
                    }
                    else
                    {
                        Debug.Log(arr[i] + " not found");
                    }


                }
                Debug.Log("iteration finish");
            }







        }

    }
}
