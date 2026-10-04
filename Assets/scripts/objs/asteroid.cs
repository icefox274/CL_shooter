using UnityEngine;

public class asteroid : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.TryGetComponent<EnemyMovement>(out EnemyMovement e);
            e.Hp -= 45;
            GameManager.instance.KillCount--;
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            collision.TryGetComponent<enemyBulletTrack>(out enemyBulletTrack e2);
            e2.hp -= 45;
            GameManager.instance.KillCount--;
            Destroy(gameObject);
        }

        else if(collision.gameObject.CompareTag("Barrier"))
        {
            Destroy(gameObject);
        }

        else if (collision.gameObject.CompareTag("Player"))
        {
            collision.TryGetComponent<Player>(out Player P);
            P.TakeDamage(15);
            Destroy(gameObject);
        }
    }
}
