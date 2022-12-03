using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] int damage = 15;

    DisplayDamage displayDamageScript;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
        displayDamageScript = FindObjectOfType<DisplayDamage>();
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        target.TakeDamage(damage);
        displayDamageScript.DisplayDamageProcess();
    }
}
