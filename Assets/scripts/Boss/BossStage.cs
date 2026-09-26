using UnityEngine;
using System.Collections.Generic;

public class BossStage : MonoBehaviour
{
    public List<EnemyMovement> enemies;
    public bool IsBossSHeildon = true;

    private void Start()
    {
        foreach (var system in enemies)
        {
            system.gameObject.SetActive(false);
        }
    }

    public void StartStage()
    {
        foreach (var system in enemies)
        {
            system.gameObject.SetActive(true);
        }
    }

    public bool IsComplete ()
    {
        foreach (var system in enemies)
        {
            if (system !=null)
            {
                return false;
            }
        }
        return true;
    }
}
