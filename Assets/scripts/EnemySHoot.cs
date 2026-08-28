using UnityEngine;

public class EnemySHoot : MonoBehaviour
{
    private float cooldownTIme;
    void Update()
    {
        cooldownTIme += Time.deltaTime;

        if(cooldownTIme > 1.7f)
        {
            EnemyBullet eb = Pooling.Instance.EBPool;
            cooldownTIme = 0;
        }
    }
}
