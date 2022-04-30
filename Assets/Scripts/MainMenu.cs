using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstLevel;
    public GameObject pausa;
    public string information;
    public string MainM;
    public static bool animationStart;
    public void startButton()
    {
        pausa.SetActive(false);
        SceneManager.LoadScene(firstLevel);
        LevelGenerator.speed = LevelGenerator.maxSpeed;
        if (Collision.gameOverBool)
        {
            animationStart = true;
        }
    }
    public void optionButton()
    {
        SceneManager.LoadScene("information");
    }
    public void exitButton()
    {
        SceneManager.LoadScene(MainM);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausa.SetActive(true);
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            pausa.SetActive(false);
            Time.timeScale = 1;
        }
    }
    void Start()
    {
        pausa.SetActive(false);
    }
    public void MainMenuButtom()
    {
        SceneManager.LoadScene("SelectLevel");
    }
    public void MainMenu2()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

