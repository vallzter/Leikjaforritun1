using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class player : MonoBehaviour {
    public float movementspeed = 10f;
    float hreyfing = 0f;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        hreyfing = Input.GetAxis("Horizontal") * movementspeed;


	}
     
    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = hreyfing;
        rb.velocity = velocity;

        //if (rb.position.y < -2f)
        //{
          //  FindObjectOfType<GameManager>().EndGame();//Ætlaði að hafa Game over ef hann fer fyrir neðan skjáinn en er í erfiðleikum að ná því fram
        //}
    }
}
