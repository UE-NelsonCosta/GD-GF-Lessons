using UnityEngine;

public class CircleInteractable : MonoBehaviour, IInteractable
{
    public void Interact(GameObject Instigator)
    {
        Debug.Log("Circle Was Interacted With!");
    }
}
