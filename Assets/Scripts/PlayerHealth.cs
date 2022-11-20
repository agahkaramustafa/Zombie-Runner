using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int hitPoint = 100;

    public void TakeDamage(int damage)
    {
        hitPoint -= damage;
        if (hitPoint <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
            Debug.Log("Player is PEPSI");
        }
    }
}
