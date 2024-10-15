using System;
using UnityEngine;

public class HealingPickup : MonoBehaviour
{
    [SerializeField] private float AmountToHeal = 1.0f;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            HealthComponent healthComponent = col.GetComponent<HealthComponent>();
            if (healthComponent && healthComponent.CanHealAmount())
            {
                healthComponent.HealHealth(AmountToHeal);
                Destroy(gameObject);
            }
        }
    }
}
