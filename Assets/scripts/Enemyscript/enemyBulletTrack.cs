using Unity.VisualScripting;
using UnityEngine;

public class enemyBulletTrack : MonoBehaviour
{
    [SerializeField] private float speed;
    private Transform target;
    public float hp = 3;
    [SerializeField] private GameObject Item;

    private void Start()
    {
        this.transform.SetParent(null);
        target = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        transform.position =Vector3.MoveTowards( transform.position,target.position, Time.deltaTime * speed);

        if (hp <= 0)
        {
            float n = Random.Range(0, 10);
            if (n >= 3)
            {
                Instantiate(Item,transform.position,Quaternion.identity);
            }

            GameManager.instance.KillCount++;
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.TryGetComponent<EnemyMovement>(out EnemyMovement e);
            e.Hp -= 45;
            Destroy(gameObject);
        }

        else if(collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("hittrack");
            hp-=1;
        }

        else if (collision.gameObject.CompareTag("Player"))
        {
            collision.TryGetComponent<Player>(out Player P);
            P.TakeDamage(30);
            Destroy(gameObject);
        }
    }
}
