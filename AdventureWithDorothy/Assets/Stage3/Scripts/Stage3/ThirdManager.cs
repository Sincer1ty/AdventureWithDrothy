using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThirdManager : MonoBehaviour
{
    public ElfController elf;
    public Text gemCountTxt;
    public Text heartTxt;
    public Button pourButton;
    public Button menu;
    public Button restart;
    public Button goMainOver;
    public Button goMain;
    public Button restartOver;
    public WitchController witch;

    public GameObject GamePanel;
    public GameObject OverPanel;
    public GameObject MenuPanel;

    private void Awake()
    {
        

    }

    // Start is called before the first frame update
    void Start()
    {
        pourButton.onClick.AddListener(OnClickButton);
        menu.onClick.AddListener(OnClickMenu);
        restart.onClick.AddListener(OnClickRestart);
        goMain.onClick.AddListener(OnClickGomain);
        goMainOver.onClick.AddListener(OnClickGomain);
        restartOver.onClick.AddListener(OnClickRestartOver);
    }

    // Update is called once per frame
    void Update()
    {
        gemCountTxt.text = elf.gemCurr+" / " + elf.gemCounts;
        heartTxt.text = elf.heart.ToString();
    }

    public void OnClickRestartOver()
    {
        SceneManager.LoadScene(6);
    }

    public void OnClickGomain()
    {
        SceneManager.LoadScene(0);
    }
    public void OnClickRestart()
    {
        MenuPanel.SetActive(false);
        GamePanel.SetActive(true);
        elf.isStop = false;
        witch.isChase = true;
    }

    public void OnClickButton()
    {
        Debug.Log("Pour!");
        if (elf.gemCurr == 10)
            witch.health = 0;
        else
            Debug.Log("You can't do this now");
    }

    public void OnClickMenu()
    {
        GamePanel.SetActive(false);
        MenuPanel.SetActive(true);
        elf.isStop = true;
        witch.isChase = false;
    }

    public void GameOver()
    {
        GamePanel.SetActive(false);
        OverPanel.SetActive(true);
        elf.isStop = true;
        witch.isChase = false;
    }

    public void nextScence()
    {
        SceneManager.LoadScene(7);
    }
}
