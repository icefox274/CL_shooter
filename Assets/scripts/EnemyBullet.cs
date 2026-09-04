using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float speed;
    private float burntimer = 0f;

    private void Start()
    {
        this.transform.SetParent(null);
    }
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
        burntimer += Time.deltaTime;
        if (burntimer > 1.1f)
        {
            burntimer = 0f;
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("eeeeeee");
        }

        else if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("hit");

        }
    }

}
