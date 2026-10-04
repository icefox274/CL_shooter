using UnityEngine;
using System.Collections.Generic;

public class BossStage : MonoBehaviour
{
    public List<BossParts> Parts;
    public bool IsBossSHeildon = true;

    private void Start()
    {
        foreach (var system in Parts)
        {
            system.gameObject.SetActive(false);
        }
    }

    public void StartStage()
    {
        foreach (var system in Parts)
        {
            system.gameObject.SetActive(true);
        }
    }

    public bool IsComplete ()
    {
        foreach (var system in Parts)
        {
            if (system !=null)
            {
                return false;
            }

            if(system.Isdestroyed == true)
            {
                return true;
            }
        }
        return true;
    }
}
