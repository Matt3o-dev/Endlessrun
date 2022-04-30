using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public string Main;
    public void Easy()
    {
        SceneManager.LoadScene(Main);
        LevelGenerator.speed = 3;
        Collision.maxVite = 3;
        LevelGenerator.maxSpeed = 3;
    }
    public void Medium()
    {
        SceneManager.LoadScene(Main);
        LevelGenerator.speed = 4;
        Collision.maxVite = 2;
        LevelGenerator.maxSpeed = 4;
    }
    public void Hard()
    {
        SceneManager.LoadScene(Main);
        LevelGenerator.speed = 5;
        Collision.maxVite = 1;
        LevelGenerator.maxSpeed = 5;
    }
    public void Bonus()
    {
        
    }
}
