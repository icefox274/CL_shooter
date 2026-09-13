using UnityEngine;

public class EnemyBuilder 
{
    GameObject Enemyprefab;
    GameObject WeaponPrefab;

    public EnemyBuilder SetEnemyPrefabs(GameObject EnemyPrefab)
    {
        EnemyPrefab = Enemyprefab;
        return this;
    }

    public EnemyBuilder SetWeaponPrefabs(GameObject Weaponprefab)
    {
        Weaponprefab= WeaponPrefab;
        return this;
    }

    public GameObject Build()
    {
        GameObject instance = GameObject.Instantiate(Enemyprefab);

        return instance;
    }
}
