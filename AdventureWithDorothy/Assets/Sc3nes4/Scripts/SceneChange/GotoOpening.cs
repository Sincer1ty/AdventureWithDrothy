using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoOpening : MonoBehaviour
{
    //SceneManager.LoadScene("Opening"); // �� �̸�

    public void SceneChange()
    {
        SceneManager.LoadScene("Opening"); // �� �̸�
    }
}