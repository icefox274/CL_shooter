using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    private float burntimer =0f;

    private void Start()
    {
        Pooling.Instance.BPool = this;
    }

    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
        burntimer += Time.deltaTime;
        if (burntimer > 1.1f)
        {
            burntimer = 0f;
            Pooling.Instance.BPool = this;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Pooling.Instance.BPool = this;
    }
}
