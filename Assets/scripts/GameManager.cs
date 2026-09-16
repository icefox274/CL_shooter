using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int KillCount;
    public int Playerlv;
    private float lvmultiplier =1;
    private float bossmultiplier = 1;

    private void Start()
    {
        instance= this;
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
}
