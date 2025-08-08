using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreenLimit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {            
            GameObject.Destroy(collision.gameObject);
        }
    }
}
