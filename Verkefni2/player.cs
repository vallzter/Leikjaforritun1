using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]// breyta sem gefur til kynna að Rigidbody2D er alltaf í game objectivinu
public class player : MonoBehaviour {
    public float movementspeed = 10f; //bý til movement breytuna, þarf að gera þetta svo adalpersonan fari hraðar
    float hreyfing = 0f;// breytan fyrir hreyfingu adalpersonunar búinn til
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        hreyfing = Input.GetAxis("Horizontal") * movementspeed;//movement breytan, Hreyfingin er þá getAxis breytan horizontal til að hreyfa til hægri og vinstri og svo * movementSpeed svo hann fari hraðar


	}
     
    void FixedUpdate()//bý til fixed update útaf það er ekki hentugt að kóða movement í update
    {
        Vector2 velocity = rb.velocity;//til að finna movement
        velocity.x = hreyfing;
        rb.velocity = velocity;

        //if (rb.position.y < -2f)
        //{
          //  FindObjectOfType<GameManager>().EndGame();//Ætlaði að hafa Game over ef hann fer fyrir neðan skjáinn en er í erfiðleikum að ná því fram
        //}
    }
}
