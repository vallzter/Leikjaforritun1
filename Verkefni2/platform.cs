using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour {

    public float kraftHopp = 10f;//bý til breytuna krafthopp til að láta adalpersonuna hoppa hærra í byrjun
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = kraftHopp;//kallar í krafthoppið
                rb.velocity = velocity;//kallar í rigidbody 
            }
        }                 
    }
}
