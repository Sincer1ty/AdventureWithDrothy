using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoStage2 : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Stage2"); // �� �̸� �����ϱ�
    }
}
