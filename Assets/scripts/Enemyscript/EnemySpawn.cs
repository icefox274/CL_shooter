using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    private float timer=0;
    [SerializeField] GameObject Enemy;
    [SerializeField] private float Spawntime;
    [SerializeField] Transform[] SpawnPoint;
    private float timermultiplier=0;
    private int Currentlv=1;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= Spawntime)
        {
            timer = 0f;
            SummonENemy();
        }

        if (Input.GetKeyDown(KeyCode.F10))
        {
            SummonENemy();
        }

        if (Input.GetKeyDown(KeyCode.F11))
        {
            GameManager.instance.Playerlv++;
        }

        if (Input.GetKeyDown(KeyCode.F12))
        {
            GameManager.instance.Playerlv--;
        }

        if (Currentlv!=GameManager.instance.Playerlv)
        {
            if(Spawntime<=0.9f)
            {
                return;
            }
            timermultiplier += 0.005f;
            Spawntime -= timermultiplier;
            Currentlv = GameManager.instance.Playerlv;
        }
    }

    private void SummonENemy()
    {
        int n = Random.Range(0, SpawnPoint.Length);
        Instantiate(Enemy,SpawnPoint [n]);
    }
}
