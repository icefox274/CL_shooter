using UnityEngine;
using System.Collections.Generic;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private List<Enemytype> enemytypes;
    [SerializeField] private float spawnInterval=2f;
    [SerializeField] private List<Transform> SpawnPoints;

    private EnemyFactory Factory;
    private float spawnTimer;


    private void Start()
    {
        Factory = new EnemyFactory();
    }

    private void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer<=spawnInterval)
        {
            SpawnEnemy();
            spawnTimer = 0f;
        }
    }

    private void SpawnEnemy()
    {
        Enemytype enemytype = enemytypes[Random.Range(0, enemytypes.Count)];
        Transform SpawnPoint = SpawnPoints[Random.Range(0, SpawnPoints.Count)];

        GameObject enemy = Factory.CreateEnemy(enemytype, SpawnPoint);
    }
}
