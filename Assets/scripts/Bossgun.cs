using UnityEngine;

public class bossgun : MonoBehaviour
{
    [SerializeField] private BossParts bossParts;
    public int Value = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("aaaaaaa");
        Value--;

        if(Value <=0)
        {
            bossParts.progress++;
            Destroy(gameObject);
        }
    }

}
