using UnityEngine;
using UnityEngine.UI;

public class StartPoint : MonoBehaviour
{
    [SerializeField] private GameObject spawnHandler;
    [SerializeField] private DisplayHP HPD;
    [SerializeField] private Slider hpslider;
    private bool started;

    private void Start()
    {
        spawnHandler.SetActive(false);
        HPD.enabled = false;
        hpslider.value = 0.1f;
        started = false;
    }

    private void Update()
    {
        if(started==true)
        {
            hpslider.value += Time.deltaTime*100;
            if (hpslider.value == hpslider.maxValue)
            {
                spawnHandler.SetActive(true);
                hpslider.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = Color.green;
                HPD.enabled=true;
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            started = true;
        }
    }
}
