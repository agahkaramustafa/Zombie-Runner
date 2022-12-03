using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas displayDamageCanvas;
    [SerializeField] float waitTime = .3f;

    void Start() 
    {
        displayDamageCanvas.enabled = false;
    }

    public void DisplayDamageProcess()
    {
        StartCoroutine(DamageDisplay());
    }

    IEnumerator DamageDisplay()
    {
        displayDamageCanvas.enabled = true;
        yield return new WaitForSeconds(waitTime);
        displayDamageCanvas.enabled = false;
    }
}
