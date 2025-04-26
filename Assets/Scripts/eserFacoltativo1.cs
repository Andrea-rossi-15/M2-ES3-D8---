using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TabellinaDelTre : MonoBehaviour
{
  void Start()
  {

    for (int num = 1; num <= 10; num++)
    {
      int risultato = num * 3;
      Debug.Log("3 x " + num + " = " + risultato);
    }
  }





  void Update()
  {

  }
}


