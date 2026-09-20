using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DIsplayUI : MonoBehaviour
{
    [SerializeField] private TMP_Text Score;
    [SerializeField] private TMP_Text Level;
    void Update()
    {
        Score.text = ($"SCORE: {GameManager.instance.KillCount}");
        Level.text=($"LEVEL: {GameManager.instance.Playerlv}");
    }

    public void Reload()
    {
        SceneManager.LoadScene("Game");
    }
    public void Returnmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
