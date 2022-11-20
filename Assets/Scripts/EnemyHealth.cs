using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int enemyHealth = 100;

    public void TakeDamage(int damage)
    {
        BroadcastMessage("OnDamageTaken");
        enemyHealth -= damage;

        if (enemyHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GetComponent<Animator>().SetTrigger("Die");
        GetComponent<EnemyAI>().enabled = false;
        GetComponent<Collider>().enabled = false;
    }
}
