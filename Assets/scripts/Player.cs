using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    public float Hp = 100;
    private Vector2 movementV;

    private void Update()
    {
        Movement();
    }

    public void OnMove(InputValue V)
    {
        movementV = V.Get<Vector2>();
    }

    public void OnAttack()
    {
        Bullet b0 = Pooling.Instance.BPool;
    }

    private void Movement()
    {
        Vector2 v2 = movementV;

        transform.Translate(v2 * Time.deltaTime * speed);
    }

    public void TakeDamage(float Damage)
    {
        Hp-=Damage;
    }

    public void Heal(float Heal)
    {
        if(Hp>=100)
        {
            Hp = 100;
        }
        Hp += Heal;
    }
}
