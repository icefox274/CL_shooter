using UnityEngine;
using System.Collections.Generic;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] Enemytype enemytypes;
    [SerializeField] private float spawnInterval=3f;
    [SerializeField] private List<Transform> SpawnPoints;

    private EnemyFactory Factory;
    private float spawnTimer;
    private int currentlevel;


    private void Start()
    {
        Factory = new EnemyFactory();
        currentlevel = GameManager.instance.Playerlv;
    }

    private void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer>=spawnInterval)
        {
            SpawnEnemy();
            spawnTimer = 0f;
        }

        if(currentlevel!=GameManager.instance.Playerlv)
        {
            if(spawnInterval<= 0.8f)
            {
                return;
            }

            spawnInterval -= 0.1f;
            currentlevel = GameManager.instance.Playerlv;
        }
    }

    private void SpawnEnemy()
    {
        Transform SpawnPoint = SpawnPoints[Random.Range(0, SpawnPoints.Count)];

        GameObject enemy = Factory.CreateEnemy(enemytypes, SpawnPoint);
    }
}
