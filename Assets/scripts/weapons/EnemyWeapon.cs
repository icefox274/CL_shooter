using UnityEngine;

public class Enemyweapon : Weapon
{
    ProjectileStrat strat;
    private float fireTimer;
    private void Update()
    {
        fireTimer = Time.deltaTime;

        if (fireTimer >= strat.fireRate)
        {
            strat.Fire(firePoint);
            fireTimer = 0f;
        }
    }
}

