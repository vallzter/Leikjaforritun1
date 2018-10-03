using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject platformPrefab;//bý til game objest fyrir grænu platformana
    public GameObject vondirPlatforms;//bý til game object fyrir rauðu platformana
    public GameObject gameOverr;
    public int numberOfPlatforms = 200;//vil fá 200 græna
    public int numberOfBadPlatforms = 20;//vil fá 20 rauða
    public float levelWidth = 3f;
    public float minY = .2f;
    public float MaxY = 1.5f;

	// Use this for initialization
	void Start () {
        Vector3 spawnPostition = new Vector3();//segir til um að platformarnir spawni

        for (int i = 0; i < numberOfBadPlatforms; i++)
        {
            spawnPostition.x = Random.Range(-levelWidth, levelWidth);
            spawnPostition.y += Random.Range(minY, MaxY);
            Instantiate(vondirPlatforms, spawnPostition, Quaternion.identity);


            for (int j = 0; j < numberOfPlatforms; j++)
            {
                spawnPostition.x = Random.Range(-levelWidth, levelWidth);
                spawnPostition.y += Random.Range(minY, MaxY);
                Instantiate(platformPrefab, spawnPostition, Quaternion.identity);
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
