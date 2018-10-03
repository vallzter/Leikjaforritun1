using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    public player player;
    public Camera came;
    

    void Update()
    {


        if (came.transform.position.y > player.transform.position.y + 100)
        {
            Debug.Log(player.transform.position.y);
            FindObjectOfType<GameManager>().EndGame();
        }
    }
     }

