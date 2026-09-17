using UnityEngine;

public abstract class ProjectileStrat : ScriptableObject
{
    [SerializeField] protected int dAmage=1;
    [SerializeField] protected float fireRate=2;
    [SerializeField] protected float projetileSpeed;
    [SerializeField] protected float ProjectileLifetime;
    [SerializeField] protected GameObject BulletPrefab;

    public int Damage => dAmage;
    public float Firerate=> fireRate;

    public virtual void Init()
    {

    }

    public abstract void Fire(Transform FirePosition);

}