using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float speed;
    private float burntimer;
    private float Ticks=0f;

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    public void SetLifetime(float timeer)
    {
        this.burntimer = timeer;
    }

    private void Start()
    {
        this.transform.SetParent(null);
        Debug.Log($"{burntimer}");
    }
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
        Ticks+= Time.deltaTime;
        if (Ticks >= burntimer)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            return;
        }

        else if (collision.gameObject.CompareTag("Player"))
        {
            collision.TryGetComponent<Player>(out Player p);
            p.TakeDamage(1);
            Destroy(gameObject);
        }

        else if (collision.gameObject.CompareTag("Barrier"))
        {
            Destroy(gameObject);
        }
    }

}
