using TMPro;
using UnityEngine;

public class DIsplayUI : MonoBehaviour
{
    [SerializeField] private TMP_Text Score;
    [SerializeField] private TMP_Text Level;
    void Update()
    {
        Score.text = ($"SCORE: {GameManager.instance.KillCount}");
        Level.text=($"LEVEL: {GameManager.instance.Playerlv}");
    }
}
