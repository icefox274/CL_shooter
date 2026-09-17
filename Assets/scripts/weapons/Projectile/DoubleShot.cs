using UnityEngine;
[CreateAssetMenu(fileName = "DoubleShotWeapon", menuName = "Weapons/DoubleShot")]
public class DoubleShot : ProjectileStrat
{
    [SerializeField] private float Spread;
    public override void Fire(Transform FirePosition)
    {
        for(int i =0; i < 2; i++)
        {
            var Projectile = Instantiate(BulletPrefab, FirePosition.position, FirePosition.rotation);
            Projectile.transform.position = FirePosition.position*(Spread*i-1);

            var ProjectileComponent = Projectile.TryGetComponent<EnemyBullet>(out EnemyBullet b);
            b.SetSpeed(projetileSpeed);
            b.SetLifetime(ProjectileLifetime);
        }
    }
}
