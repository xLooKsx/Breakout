using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    private Rigidbody2D myRigidbody2D;
    private float horizontalMovement;
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        Vector2 vector2 = new Vector2(horizontalMovement, 0);
        myRigidbody2D.AddForce(vector2 * movementSpeed);
    }
}
