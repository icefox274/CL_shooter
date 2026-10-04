using UnityEngine;
using System.Collections.Generic;

public class BossParts : MonoBehaviour
{
    public int progress = 0;
    [SerializeField] private List<GameObject> destroyparts;
    public bool Isdestroyed;

    private void Start()
    {
        Isdestroyed = false;
    }

    private void Update()
    {
        if (progress <= destroyparts.Count)
        {
            Isdestroyed = true;
        }
    }
}
