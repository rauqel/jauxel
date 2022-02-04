using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject[] objectsToSpawn;

    bool hasSpawned;

    float timeToNextSpawn;
    float timeSinceLastSpawn = 0.0f;

    public float var1;
    public float var2;


    // Start is called before the first frame update
    void Start()
    {
        hasSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        int selection = Random.Range(0, objectsToSpawn.Length);
        timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;

        if (timeSinceLastSpawn >= var1 && timeSinceLastSpawn <= var2) 
        {
            hasSpawned = true;
            if(hasSpawned == true)
            {
                Instantiate(objectsToSpawn[selection], transform.position, Quaternion.identity);
                hasSpawned = false;
                timeSinceLastSpawn = 0.0f;
            }
        }
    }
}
