using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnPlayerHealthChanged : UnityEvent<float> { }

[System.Serializable]
public class OnPlayerDied : UnityEvent { }

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private float MaxHealth = 10.0f;
    private float CurrentHealth = 0.0f;
    private float NormalizedHealth = 0.0f;

    public OnPlayerHealthChanged OnPlayerHealthChangedEvent;
    public OnPlayerDied OnPlayerDiedEvent;

    private void Start()
    {
        ModifyHealth(MaxHealth);

        OnPlayerHealthChangedEvent.Invoke(NormalizedHealth);
    }

    public void DealDamage(float damageAmount)
    {
        ModifyHealth(-damageAmount);
        
        OnPlayerHealthChangedEvent.Invoke(NormalizedHealth);

        if (NormalizedHealth <= 0.0f)
        {
            OnPlayerDiedEvent.Invoke();
        }
    }

    public void HealHealth(float healAmount)
    {
        ModifyHealth(healAmount);

        OnPlayerHealthChangedEvent.Invoke(NormalizedHealth);
    }

    private void ModifyHealth(float modifier)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + modifier, 0.0f, MaxHealth);
        NormalizedHealth = CurrentHealth / MaxHealth;
    }

    public virtual bool CanHealAmount(float amount = 0.0f)
    {
        return NormalizedHealth < 1.0f;
    }
}
