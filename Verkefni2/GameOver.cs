using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    public player player;
    public Camera came;
    

    void Update()//REYNDI AÐ GERA ÞESSA SKIPUN! En fékk hana ekki til að virka svo hún er useless, en ætla hafa hana með svo þú sjáir að ég hafi reynt.
    {


        if (came.transform.position.y > player.transform.position.y + 100)
        {
            Debug.Log(player.transform.position.y);
            FindObjectOfType<GameManager>().EndGame();
        }
    }
     }

