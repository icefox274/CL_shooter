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
        Debug.Log($"{Enemyprefab == null}");
        GameObject instance = GameObject.Instantiate(Enemyprefab);

        Debug.Log($"{Spawnposition == null}");
        instance.transform.position = (Vector3)Spawnposition.position;

        return instance;
    }
}
