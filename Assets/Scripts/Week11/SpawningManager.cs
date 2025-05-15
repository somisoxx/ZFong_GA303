using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class SpawningManager : MonoBehaviour
{
    
    public List<GameObject> gameObjects = new List<GameObject>();
    //public int numPoke;
    public GameObject pichuPrefab;
    public GameObject emolgaPrefab;
    public GameObject mimikyuPrefab;
    public GameObject pikachuPrefab;

    Vector2 randomPosition;
    public float spawnRangeX = 8.5f;
    public float spawnRangeY = 3.5f;

    float x;
    float y;

    float rDirect;
    public float speed = 3f;

    void Start()
    {
        /* TEST 1
        numPoke = Random.Range(5, 15); //random AMOUNT range
        float randomX = Random.Range(-spawnRangeX, spawnRangeX); //random POSITION range
        float randomY = Random.Range(-spawnRangeY, spawnRangeY);

        randomPosition = new Vector2(randomX, randomY);
        transform.position = randomPosition;


        for (int i = 0; i < numPoke; i++) //instantiates rAMOUNT
        {
            Instantiate(pichuPrefab);
            Instantiate(emolgaPrefab);
            Instantiate(mimikyuPrefab);
        }
        */

        //TEST 2
        //numPoke = Random.Range(5, 20);
       
        Vector2 spawnPositions = new Vector2(x, y);
        Quaternion spawnRotation = Quaternion.identity;
        
        
        x = Random.Range(-spawnRangeX, spawnRangeX);
        y = Random.Range(-spawnRangeY, spawnRangeY);
        Instantiate(pikachuPrefab, new Vector2(x, y), spawnRotation);
        pikachuPrefab.GetComponent<SpriteRenderer>().sortingOrder = 0;
        
        for (int i = 0; i < Random.Range(20,30); i++)
        {
            x = Random.Range(-spawnRangeX, spawnRangeX);
            y = Random.Range(-spawnRangeY, spawnRangeY);
            Instantiate(pichuPrefab, new Vector2(x, y), spawnRotation);
        }
        for (int i = 0; i < Random.Range(20, 30); i++)
        {
            x = Random.Range(-spawnRangeX, spawnRangeX);
            y = Random.Range(-spawnRangeY, spawnRangeY);
            Instantiate(emolgaPrefab, new Vector2(x, y), spawnRotation);
        }
        for (int i = 0; i < Random.Range(20, 30); i++)
        {
            x = Random.Range(-spawnRangeX, spawnRangeX);
            y = Random.Range(-spawnRangeY, spawnRangeY);
            Instantiate(mimikyuPrefab, new Vector2(x, y), spawnRotation);
        }
    }
    void Update()
    {
        
        //Vector2 spawnDirection = new Vector2((Random.Range(-1, 1)), (Random.Range(-1, -1)));
        
    }
}
