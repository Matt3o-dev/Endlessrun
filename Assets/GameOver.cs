using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string Main;
    public string MainMenu;
    void RestartButton()
    {
        SceneManager.LoadScene(Main);
    }
    void MainMenuButton()
    {
        SceneManager.LoadScene(MainMenu);
    }
}
