using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawnDelay;

    float nextSpawnTime;

    public float spawnRadius;

    Camera mainCamera;

    public Transform player;

    public Transform enemy;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;

        spawnRadius = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + spawnDelay;

            // Spawn enemy
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        Transform newEnemy = Instantiate(enemy, GetRandomSpawnCoord(), Quaternion.identity);
    }

    Vector3 GetRandomSpawnCoord()
    {
        float randomAngle = Random.Range(0, 360);

        float x = player.position.x + spawnRadius * Mathf.Cos(randomAngle);
        float z = player.position.z + spawnRadius * Mathf.Sin(randomAngle);

        return new Vector3(x, 0, z);
    }

}
