using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionZone : MonoBehaviour
{
   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "colzone")
        {
            print("Enter");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "colzone")
        {
            print("Stay");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "colzone")
        {
            print("Exit");
        }
    }    
   

}
