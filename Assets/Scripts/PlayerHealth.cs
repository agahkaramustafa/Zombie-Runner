using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int hitPoint = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
