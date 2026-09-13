using UnityEngine;

public class EnemyFactory 
{
    public GameObject CreateEnemy(Enemytype enemytype)
    {
        EnemyBuilder builder = new EnemyBuilder()
        .SetEnemyPrefabs(enemytype.EnemyPrefab)
        .SetWeaponPrefabs(enemytype.WeaponPrefab);


        return builder.Build();
    }
}
