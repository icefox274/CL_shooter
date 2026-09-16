using UnityEngine;

public abstract class ProjectileStrat : ScriptableObject
{
    [SerializeField] protected int dAmage=1;
    public float fireRate=2;
    [SerializeField] private float projetileSpeed;
    [SerializeField] private float ProjectileLifetime;
    [SerializeField] private GameObject BulletPrefab;

    public int Damage => dAmage;
    public float Firerate=> fireRate;

    public virtual void Init()
    {

    }

    public abstract void Fire(Transform FirePosition);


}
