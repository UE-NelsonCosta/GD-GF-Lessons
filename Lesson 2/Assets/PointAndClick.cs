using Unity.VisualScripting;
using UnityEngine;

public class PointAndClick : MonoBehaviour
{
    private Camera MainCamera = null;
    
    private void Start()
    {
        MainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            float distance = 15.0f;
            
            Vector3 RayOrigin = MainCamera.GetComponent<Transform>().position;
            Ray PhysicsRay = new Ray
                (
                    
                );
            // Example Screen To World Point
            /* Vector3 WorldPoint = MainCamera.ScreenToWorldPoint
                (
                    new Vector3
                        (
                            Input.mousePosition.x, 
                            Input.mousePosition.y,
                            distance
                        )
                ); 
                
             Debug.DrawLine(MainCamera.GetComponent<Transform>().position, WorldPoint);

                */
            
            
            Ray RaycastRay = MainCamera.ScreenPointToRay
                (
                    new Vector3
                        (
                            Input.mousePosition.x,
                            Input.mousePosition.y,
                            1.0f
                        )
                );
            
            Debug.DrawRay(RaycastRay.origin, RaycastRay.direction);
            
            RaycastHit2D HitInformation = Physics2D.Raycast
                (
                    RaycastRay.origin, 
                    RaycastRay.direction, 
                    distance
                );
            
            Debug.DrawLine(RaycastRay.origin, RaycastRay.origin + RaycastRay.direction * distance);

            if (HitInformation.collider != null)
            {
                IInteractable interactableObject = HitInformation.collider.GetComponent<IInteractable>();
                if (interactableObject != null)
                {
                    interactableObject.Interact(gameObject);
                }
            }
        }
    }

}
