using UnityEngine;

public class endbarrier : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("eeeeee");
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("fffffff");
            Destroy(collision.gameObject);
        }
    }
}
