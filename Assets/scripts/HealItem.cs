using UnityEngine;

public class HealItem : MonoBehaviour
{
    [SerializeField] private float Healamount;

    private void Start()
    {
        this.transform.SetParent(null);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.gameObject.TryGetComponent<Player>(out Player p);
            p.Heal(Healamount);
            Destroy(gameObject);
        }
    }
}
