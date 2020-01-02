using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    // needed for spawning
    [SerializeField]
    GameObject prefabRock;

    [SerializeField]
    Sprite greenrock;
    [SerializeField]
    Sprite magentarock;
    [SerializeField]
    Sprite whiterock;

    // spawn control
    const float SpawnDelay = 1;
    Timer spawnTimer;

    // spawn location support
    const int SpawnBorderSize = 100;
    int minSpawnX;
    int maxSpawnX;
    int minSpawnY;
    int maxSpawnY;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // save spawn boundaries for efficiency
        minSpawnX = SpawnBorderSize;
        maxSpawnX = Screen.width - SpawnBorderSize;
        minSpawnY = SpawnBorderSize;
        maxSpawnY = Screen.height - SpawnBorderSize;

        // create and start timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = SpawnDelay;
        spawnTimer.Run();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // check for time to spawn a new teddy bear
        if (spawnTimer.Finished && GameObject.FindGameObjectsWithTag("Rock").Length < 3)
        {
            SpawnRock();

            // change spawn timer duration and restart
            spawnTimer.Duration = SpawnDelay;
            spawnTimer.Run();
        }
    }

    /// <summary>
    /// Spawns a new teddy bear at a random location
    /// </summary>
    void SpawnRock()
    {
        // generate random location and create new teddy bear
        Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX),
            Random.Range(minSpawnY, maxSpawnY),
            -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
        GameObject rock = Instantiate(prefabRock) as GameObject;
        rock.transform.position = worldLocation;

        SpriteRenderer spriteRenderer = rock.GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);

        if (spriteNumber == 0)
        {
            spriteRenderer.sprite = greenrock;
        }

        else if (spriteNumber == 2)
        {
            spriteRenderer.sprite = magentarock;
        }

        else 
        {
            spriteRenderer.sprite = whiterock;
        }
    }
}
