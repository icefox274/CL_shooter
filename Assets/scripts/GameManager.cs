using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int KillCount;
    public int Playerlv;

    private void Start()
    {
        instance= this;
    }

    void Update()
    {
        if(KillCount>=Playerlv*2)
        {
            Playerlv++;
        }
    }
}
