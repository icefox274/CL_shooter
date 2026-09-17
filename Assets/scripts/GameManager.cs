using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int KillCount;
    public int Playerlv;
    private float lvmultiplier =1;
    private float bossmultiplier = 1;
    public bool Gameover;
    [SerializeField] private Image Gameoverimage;

    private void Start()
    {
        instance= this;
        Gameoverimage.gameObject.SetActive(false);
        Gameover = false;
    }

    void Update()
    {
        if(KillCount>=Playerlv*(2*lvmultiplier))
        {
            Playerlv++;
            lvmultiplier += 1.1f;
        }

        if(KillCount>= 100*bossmultiplier)
        {
            Debug.Log("insert boss here");
            bossmultiplier++;
        }


        //디버깅용 코드 VVV
        if(Input.GetKeyDown(KeyCode.F10))
        {
            Playerlv++;
        }

        if(Input.GetKey(KeyCode.F11))
        {
            KillCount++;
        }
    }

    public void GameOverLoad ()
    {
        Gameoverimage.gameObject.SetActive(true);
        Gameover = true;
    }
}
