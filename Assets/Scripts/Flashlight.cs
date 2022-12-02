using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] float lightDecay = .1f;
    [SerializeField] float angleDecay = 1f;
    [SerializeField] float minimumAngle = 40f;

    Light myLight;

    void Start() 
    {
        myLight = GetComponent<Light>();
    }

    void Update() 
    {
        DecreaseLightAngle();
        DecreaseLightIntensity();
    }

    void DecreaseLightIntensity()
    {
        myLight.intensity -= lightDecay * Time.deltaTime;
    }

    void DecreaseLightAngle()
    {
        if (myLight.spotAngle >= minimumAngle)
        {
            myLight.spotAngle -= angleDecay * Time.deltaTime;
        }
        else
        {
            return;
        }
    }
}
