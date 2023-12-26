using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelController : MonoBehaviour
{
    public GameObject barrelWater;
    public ElfController elf;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Swap();
    }

    void Swap()
    {
        if (elf.gemCurr == 10)
        {
            this.gameObject.SetActive(false);
            barrelWater.SetActive(true);
        }
    }
}
