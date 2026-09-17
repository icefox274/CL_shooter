using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class Pooling : MonoBehaviour
{
    public static Pooling Instance;
    public Queue<Bullet> pool = new Queue<Bullet>();
    public Queue<EnemyBullet> Epool = new Queue<EnemyBullet>();
    [SerializeField] private Bullet Bulletprefab;
    [SerializeField] private EnemyBullet EbulletPrefab;
    [SerializeField] private Transform bullettrans;
    //public Transform enemyBulletTrans;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instance = this;
    }


    public Bullet BPool
    {
        get
        {
            Bullet bullet = null;
            if (pool.Count == 0)
            {
                bullet = Instantiate(Bulletprefab,bullettrans);
                bullet.transform.SetParent(null);
                pool.Enqueue(bullet);
            }
            bullet = pool.Dequeue();
            bullet.transform.position=bullettrans.position;
            bullet.gameObject.SetActive(true);

            return bullet;
        }
        set
        {
            Bullet bullet = value;
            bullet.transform.rotation = Quaternion.identity;
            value.gameObject.SetActive(false);
            pool.Enqueue(value);
        }
    }
}
