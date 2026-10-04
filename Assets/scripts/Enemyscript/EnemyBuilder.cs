using UnityEngine;

public class EnemyBuilder 
{
    GameObject Enemyprefab;
    GameObject WeaponPrefab;
    Transform Spawnposition;

    public EnemyBuilder SetEnemyPrefabs(GameObject Enemyprefab)
    {
        this.Enemyprefab = Enemyprefab;
        return this;
    }

    public EnemyBuilder SetTransform(Transform Setpoint)
    {
        Spawnposition=Setpoint; 
        return this;
    }

    public GameObject Build()
    {
        GameObject instance = GameObject.Instantiate(Enemyprefab);

        instance.transform.position = (Vector3)Spawnposition.position;

        return instance;
    }
}
