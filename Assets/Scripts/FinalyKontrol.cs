using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalyKontrol : MonoBehaviour
{
   
   private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag=="Player")
        {
            LevelKontroller.instance.NextLevel();
           // PlayerKontroller.instance.ilk_pozisyon();   
        }
    }
}
