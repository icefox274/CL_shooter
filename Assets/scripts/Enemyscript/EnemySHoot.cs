using UnityEngine;

public class EnemySHoot : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float Freq;
    [SerializeField] private float Ampl;
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private Transform BulletPoint;
    public int Hp = 100;
    private float SinCent;
    private float cooldownTIme;

    private void Start()
    {
        SinCent=transform.position.x;
    }

    void Update()
    {
        cooldownTIme += Time.deltaTime;
        if(cooldownTIme > 1.7f)
        {
            cooldownTIme = 0;
            Instantiate(BulletPrefab,BulletPoint); 
        }
        Move();

        if (Hp <= 0)
        {
            Debug.Log("died");
            GameManager.instance.KillCount++;
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        Vector2 mpos = transform.position;
        float sin = Mathf.Sin(mpos.y*Freq)*Ampl;
        mpos.y -= speed * Time.deltaTime;
        mpos.x=SinCent+sin;
        transform.position = mpos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("EnemyBullet"))
        {
            return;
        }

        else if(collision.gameObject.CompareTag("Bullet"))
        {
            Hp--;
        }

        else if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("collided");
            GameManager.instance.KillCount++;
            Destroy(gameObject);
        }


    }
}
