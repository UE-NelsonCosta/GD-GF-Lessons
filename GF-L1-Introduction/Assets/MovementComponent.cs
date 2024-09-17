using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementComponent : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    float VelocityModifier = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        VelocityModifier += Input.GetAxis("Mouse ScrollWheel");
        
        Vector2 DirectionToMove = new Vector2
        (
            Input.GetAxis("Horizontal") * VelocityModifier,
            myRigidbody.velocity.y
        );

        myRigidbody.velocity = DirectionToMove;

    }
}
