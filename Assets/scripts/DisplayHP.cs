using UnityEngine;
using UnityEngine.UI;

public class DisplayHP : MonoBehaviour
{
    [SerializeField] private Slider hpSlider;
    [SerializeField] private Player player;
    private void Update()
    {
        hpSlider.value = player.Hp;

        if (hpSlider.value == hpSlider.maxValue)
        {
            hpSlider.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = Color.green;
        }

        if (hpSlider.value <= 99)
        {
            hpSlider.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = Color.white;
        }

        if(player.Hp<=15f)
        {
            hpSlider.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = Color.red;
        }
    }
}
