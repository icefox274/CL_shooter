using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected ProjectileStrat strate;
    [SerializeField] protected Transform firePoint;

    private void Start()
    {
        strate.Init();
    }

    public void SetWeaponStrats(ProjectileStrat projectile)
    {
        strate = projectile;
        projectile.Init();
    }
}

