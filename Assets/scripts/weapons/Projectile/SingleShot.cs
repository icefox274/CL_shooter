using UnityEngine;

[CreateAssetMenu(fileName = "SIngleShotWeapon", menuName = "Weapons/Singleshot")]
public class SingleShot : ProjectileStrat
{
    public override void Fire(Transform FirePosition)
    {
        var Projectile = Instantiate(BulletPrefab, FirePosition.position, FirePosition.rotation);
        Projectile.transform.position = FirePosition.position;

        var ProjectileComponent = Projectile.TryGetComponent<EnemyBullet>(out EnemyBullet b);
        b.SetSpeed(projetileSpeed);
        b.SetLifetime(ProjectileLifetime);
    }
}
