using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class score : MonoBehaviour
{
    public static int coin;
    
    
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player"))
        {
            coin += 1;
            Destroy(this.gameObject);
        }

    }
    
 

   
    void Update()
    {

    }
}
