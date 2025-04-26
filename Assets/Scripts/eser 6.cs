using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eser6 : MonoBehaviour
{






    void Start()
    {



        {


            int GeneraArray = Random.Range(1, 101);


            int[] arr = new int[20];
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



            int SommaArray = arr[0] + arr[1] + arr[2] + arr[3] + arr[4] + arr[5] + arr[6] + arr[7] + arr[8] + arr[9] + arr[10] + arr[11] + arr[12] + arr[13] + arr[14] + arr[15] + arr[16] + arr[17] + arr[18] + arr[19];
            Debug.Log(SommaArray);

            int StampaArray = Random.Range(arr[0], arr[19]);
            Debug.Log(StampaArray);


        }




























    }







}
