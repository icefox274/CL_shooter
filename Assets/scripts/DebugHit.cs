using UnityEngine;

public class DebugHit : MonoBehaviour
{
    public int Value = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("aaaaaaa");
        Value--;

        if(Value <=0)
        {
            Destroy(gameObject);
        }
    }

}
