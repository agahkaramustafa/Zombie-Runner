using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float angleToAdd = 40f;
    [SerializeField] float intensityToAdd = 3f;

    Flashlight myFlashlight;

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            myFlashlight = FindObjectOfType<Flashlight>();
            myFlashlight.RestoreLightAngle(angleToAdd);
            myFlashlight.RestoreLightIntensity(intensityToAdd);
            Destroy(gameObject);
        }
    }
}
