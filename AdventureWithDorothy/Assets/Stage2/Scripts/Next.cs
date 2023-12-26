using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public SecondManager manager;
    public GameObject NextText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        NextText.SetActive(true);
        manager.NextstageStart();
    }
}
