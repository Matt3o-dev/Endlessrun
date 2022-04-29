using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstLevel;
    public string option;
    public GameObject pausa;
    public string information;
    public string MainM;
    public void startButton()
    {
        Time.timeScale = 1;
        pausa.SetActive(false);
        SceneManager.LoadScene(firstLevel);
    }
    public void optionButton()
    {
        SceneManager.LoadScene(option);
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
    }
    void Start()
    {
        pausa.SetActive(false);
    }
    void startAgain()
    {
        SceneManager.LoadScene(firstLevel);
    }
    void informationButton()
    {
        SceneManager.LoadScene(information);
    }
}

