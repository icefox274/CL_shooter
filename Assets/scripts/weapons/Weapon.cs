using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private ProjectileStrat strat;
    [SerializeField] protected Transform firePoint;

    private void Start()
    {
        strat.Init();
    }

    public void SetWeaponStrats(ProjectileStrat projectile)
    {
        strat = projectile;
        projectile.Init();
    }
}

