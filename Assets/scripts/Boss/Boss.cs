using UnityEngine;
using System.Collections.Generic;

public class Boss : MonoBehaviour
{
    [SerializeField] private float MaxHP = 100;
    private float HP;
    [SerializeField] Collider2D Sheild;
    private int CurrentStage = 0;
    private List<BossStage> stages;

    private void Awake()
    {
        HP = MaxHP;
        Sheild = GetComponent<Collider2D>();
    }

    private void Start()
    {
        Sheild.enabled = true;
    }

    void AdvanceNextStage()
    {
        CurrentStage++;
        Sheild.enabled=true;

        if(CurrentStage<stages.Count)
        {
            StartSTage();
        }
    }

    void checkStageCOmplete()
    {
        if (stages[CurrentStage].IsComplete())
        {
            AdvanceNextStage();
        }
    }

    void StartSTage()
    {
        stages[CurrentStage].StartStage();
        Sheild.enabled = !stages[CurrentStage].IsBossSHeildon;
    }

    void BossDefeated()
    {
        Destroy(gameObject);
    }
}
