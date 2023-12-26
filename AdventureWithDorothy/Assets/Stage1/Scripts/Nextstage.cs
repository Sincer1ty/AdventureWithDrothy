using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextstage : MonoBehaviour
{
    public GameManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
            manager.NextstageStart();
    }
}
