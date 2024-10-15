using UnityEngine;

public class SquareInteractable : MonoBehaviour, IInteractable
{
    public void Interact(GameObject Instigator)
    {
        Debug.Log("Square Was Interacted With!");        
    }
}
