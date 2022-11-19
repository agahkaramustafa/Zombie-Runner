using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("You took 10 bullets");
            Destroy(gameObject);
        }
    }
}