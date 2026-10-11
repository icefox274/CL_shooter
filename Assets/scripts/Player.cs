using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject explosion;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip Firesound;
    [SerializeField] private AudioClip hitsound;
    [SerializeField] private AudioClip healsound;
    [SerializeField] private AudioClip diesound;
    public float Hp = 100;
    private Vector2 movementV;
    [SerializeField]private bool isdied;

    private void Start()
    {
        isdied = false;
    }

    private void Update()
    {
        Movement();
        if (Hp <= 0)
        {
            Die();
        }
    }

    public void OnMove(InputValue V)
    {
        if (GameManager.instance.Gameover == false)
        {
            movementV = V.Get<Vector2>();
        }

    }

    public void OnAttack()
    {
        if (GameManager.instance.Gameover == false)
        {
            Bullet b0 = Pooling.Instance.BPool;
            source.PlayOneShot(Firesound);
        }
    }

    private void Die()
    {
        if(isdied==false)
        {
            Debug.Log("player died");
            source.PlayOneShot(diesound);
            speed = 0;
            spriteRenderer.enabled = false;
            Instantiate(explosion, transform.position, Quaternion.identity);
            GameManager.instance.GameOverLoad();
            isdied =true;
        }
    }

    private void Movement()
    {
        Vector2 v2 = movementV;

        transform.Translate(v2 * Time.deltaTime * speed);
    }

    public void TakeDamage(float Damage)
    {
        Hp -=Damage;
        source.PlayOneShot(hitsound);
    }

    public void Heal(float Heal)
    {
        if(Hp>=100)
        {
            Hp = 100;
        }
        Hp += Heal;
        source.PlayOneShot(healsound);
    }
}
