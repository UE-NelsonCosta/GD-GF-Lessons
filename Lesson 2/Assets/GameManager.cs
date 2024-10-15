using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        HealthComponent PlayerHealth = FindObjectOfType<HealthComponent>();
        if (PlayerHealth)
        {
            PlayerHealth.OnPlayerDiedEvent.AddListener( OnPlayerDied );
        }
    }

    private void OnPlayerDied()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
