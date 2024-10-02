using System;
using UnityEngine;

public class DamagePlayerOnTouch : MonoBehaviour
{
    [SerializeField] private float DamageToDeal = 1;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            HealthComponent healthComponent = collider.GetComponent<HealthComponent>();
            if (healthComponent)
            {
                healthComponent.DealDamage(DamageToDeal);
            }
        }
    }
}
