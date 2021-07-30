using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatasAkhirSampah : MonoBehaviour
{
    //Check if any game object enter the trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy the game object
        Destroy(collision.gameObject); 
    }
}
