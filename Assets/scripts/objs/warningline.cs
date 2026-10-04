using UnityEngine;

public class warningline : MonoBehaviour
{
    [SerializeField] private GameObject Line;
    [SerializeField] private GameObject AsteroidObject;
    [SerializeField] private Transform spawnpoint;
    [SerializeField]private float timer;
    private float lineHeight;
    private Vector3 size;

    private void Start()
    {
        lineHeight = timer;
        size = new Vector3(1f, lineHeight, 1f);
    }

    void Update()
    {
        timer-= Time.deltaTime;
        Line.transform.localScale = size;
        size.y -= Time.deltaTime;
        if(timer<=0)
        {
            Instantiate(AsteroidObject, spawnpoint.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
