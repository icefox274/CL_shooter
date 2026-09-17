using UnityEngine;

public class Enemyweapon: Weapon
{
    private float fireTimer=0;

    private void Start()
    {

    }
    private void Update()
    {
        fireTimer += Time.deltaTime;

        if (fireTimer >= strate.Firerate)
        {
            strate.Fire(firePoint);
            fireTimer = 0f;
        }
    }
}

