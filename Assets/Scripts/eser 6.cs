using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eser6 : MonoBehaviour
{






    void Start()
    {

        int[] arr = new int[20];


        {
            for (int i = 0; i < arr.Length; i++)
            {


                int GeneraArray = Random.Range(1, 101);

                arr[0] = GeneraArray;
                arr[1] = GeneraArray;
                arr[2] = GeneraArray;
                arr[3] = GeneraArray;
                arr[4] = GeneraArray;
                arr[5] = GeneraArray;
                arr[6] = GeneraArray;
                arr[7] = GeneraArray;
                arr[8] = GeneraArray;
                arr[9] = GeneraArray;
                arr[10] = GeneraArray;
                arr[11] = GeneraArray;
                arr[12] = GeneraArray;
                arr[13] = GeneraArray;
                arr[14] = GeneraArray;
                arr[15] = GeneraArray;
                arr[16] = GeneraArray;
                arr[17] = GeneraArray;
                arr[18] = GeneraArray;
                arr[19] = GeneraArray;


                

                int SommaArray = 0;
                SommaArray = SommaArray + i;
                Debug.Log(SommaArray + arr[i]);

                int StampaArray = Random.Range(arr[0], arr[19]);
                Debug.Log(StampaArray);
            }



        }




























    }







}
