using UnityEngine;
using UnityEngine.UI;

public class DisplayHP : MonoBehaviour
{
    [SerializeField] private Slider hpSlider;
    [SerializeField] private Player player;
    private void Update()
    {
        hpSlider.value = player.Hp;
    }
}
