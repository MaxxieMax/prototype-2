using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefebs;
    private float spawnRangex = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    //public int animalIndex;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpanwRandomAnimals", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    void SpanwRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefebs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex), 0, spawnPosZ);

        Instantiate(animalPrefebs[animalIndex], spawnPos, animalPrefebs[animalIndex].transform.rotation);
    }
}
