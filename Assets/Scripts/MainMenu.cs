using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstLevel;

    public void startButton()
    {
        SceneManager.LoadScene(firstLevel);
    }
    public void optionButton()
    {

    }
    public void exitButton()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}

