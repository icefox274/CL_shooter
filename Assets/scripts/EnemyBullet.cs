using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float speed;
    private float burntimer = 0f;
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
        burntimer += Time.deltaTime;
        if (burntimer > 1.1f)
        {
            burntimer = 0f;
            Pooling.Instance.EBPool = this;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit");
        Pooling.Instance.EBPool = this;
    }

}
