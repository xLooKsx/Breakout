using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Rigidbody2D myRigidbody2D;
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Rigidbody2D playerRigidBody = collision.gameObject.GetComponent<Rigidbody2D>();
            myRigidbody2D.velocity = new Vector2(playerRigidBody.velocity.x * 0.5f,  Mathf.Max(myRigidbody2D.velocity.y, 12f));

        }
        
    }
}
