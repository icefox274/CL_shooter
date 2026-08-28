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
    [SerializeField] private Transform enemyBulletTrans;
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
            value.gameObject.SetActive(false);
            pool.Enqueue(value);
        }
    }

    public EnemyBullet EBPool
    {
        get
        {
            EnemyBullet ebullet = null;
            if (pool.Count == 0)
            {
                ebullet = Instantiate(EbulletPrefab, enemyBulletTrans);
                ebullet.transform.SetParent(null);
                Epool.Enqueue(ebullet);
            }
            ebullet = Epool.Dequeue();
            ebullet.transform.position = enemyBulletTrans.position;
            ebullet.gameObject.SetActive(true);

            return ebullet;
        }
        set
        {
            EnemyBullet ebullet = value;
            value.gameObject.SetActive(false);
            Epool.Enqueue(value);
        }
    }
}
