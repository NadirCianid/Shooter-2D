using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float spawnDelay = 3;
    Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while(true)
        {
            float xPos = Random.Range(-player.xBorders, player.xBorders);
            float yPos = Random.Range(-player.yBorders, player.yBorders);

            Vector3 spawnPoint = new Vector3(xPos, yPos, 0);
            Instantiate(enemy, spawnPoint, Quaternion.identity);
            
            yield return new WaitForSecondsRealtime(spawnDelay);
        }
        

        
    }
}
