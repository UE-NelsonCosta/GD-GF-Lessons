using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnPlayerHealthChanged : UnityEvent<float> { }

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private float MaxHealth = 10.0f;
    private float CurrentHealth = 0.0f;
    private float NormalizedHealth = 0.0f;

    public OnPlayerHealthChanged OnPlayerHealthChangedEvent;
    
    private void Start()
    {
        CurrentHealth = MaxHealth;
        NormalizedHealth = CurrentHealth / MaxHealth;
        
        OnPlayerHealthChangedEvent.Invoke(NormalizedHealth);
    }
    
    public void DealDamage(float damageAmount)
    {
        CurrentHealth -= damageAmount;
        NormalizedHealth = CurrentHealth / MaxHealth;
        
        OnPlayerHealthChangedEvent.Invoke(NormalizedHealth);
    }
}
