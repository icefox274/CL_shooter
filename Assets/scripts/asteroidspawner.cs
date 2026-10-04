using UnityEngine;

public class asteroidspawner : MonoBehaviour
{
    [SerializeField] private GameObject AsteroidSpawn;
    [SerializeField] private float spawnTime;
    [SerializeField] private int StartLv;
    private float timer;
    private int currentlevel;

    private void Start()
    {
        currentlevel = StartLv;
    }

    private void Update()
    {
        if(GameManager.instance.Playerlv>=StartLv)
        {

            if(GameManager.instance.Gameover==true)
            {
                return;
            }

            timer -= Time.deltaTime;

            if(timer<=0)
            {
                float N = Random.Range(4.98f, -4.98f);
                Instantiate(AsteroidSpawn, new Vector3(0f,N,0f), Quaternion.identity);
                timer = spawnTime;
            }

            if(currentlevel!=GameManager.instance.Playerlv)
            {
                if(spawnTime<= 0.7f)
                {
                    return;
                }
                spawnTime -= 0.2f;
                currentlevel = GameManager.instance.Playerlv;
            }
        }
    }

}
