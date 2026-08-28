using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
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
            Bullet b = Pooling.Instance.BPool;
    }

    private void Movement()
    {
        Vector2 v2 = movementV;

        transform.Translate(v2 * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("bbbbbb");
    }

}
