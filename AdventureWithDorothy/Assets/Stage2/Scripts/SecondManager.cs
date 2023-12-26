using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondManager : MonoBehaviour
{
    public Player2 player2;
    public int stage;
    public int hay;

    public GameObject GamePanel2;
    public GameObject OverPanel2;
    public GameObject MenuPanel2;

    public Text haytxt;
    public Text playerHealth2;


    public void NextstageStart()
    {
        SceneManager.LoadScene("St2After");
    }


    public void stageEnd2()
    {
        stage++;

    }
    public void GameOver2()
    {
        GamePanel2.SetActive(false);
        OverPanel2.SetActive(true);

    }

    public void Menu2()
    {
        GamePanel2.SetActive(false);
        MenuPanel2.SetActive(true);
    }

    public void MenuButton2()
    {
        Menu2();
    }

    public void Restart2()
    {
        SceneManager.LoadScene(0);
    }
    private void LateUpdate()
    {

        playerHealth2.text = "[" + player2.health2 + "]";

        //haytxt.text = hay.ToString();
        haytxt.text = player2.shieldnum.ToString();

    }
}
