using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    private float timer=0;
    [SerializeField] GameObject Enemy;
    [SerializeField] Transform SpawnPoint;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1.5f)
        {
            timer = 0f;
            SummonENemy();
        }

        if (Input.GetKeyDown(KeyCode.F11))
        {
            SummonENemy();
        }
    }

    private void SummonENemy()
    {
        Instantiate(Enemy,SpawnPoint);
    }
}
