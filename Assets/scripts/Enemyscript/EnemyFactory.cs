using UnityEngine;

public class EnemyFactory 
{
    public GameObject CreateEnemy(Enemytype enemytype, Transform transform)
    {
        
        EnemyBuilder builder = new EnemyBuilder()
        .SetEnemyPrefabs(enemytype.EnemyPrefab)
        .SetTransform(transform);
        //.SetWeaponPrefabs(enemytype.WeaponPrefab);


        return builder.Build();
    }
}