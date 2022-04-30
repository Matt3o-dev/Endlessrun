using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    int deadplayer = 1;
    private Animator animator;
    public GameObject Player;
    bool idle = false;
    public static int maxVite = 1;
    public GameObject Gameover;
    public GameObject Game;
    public static bool gameOverBool;
    private int ScoreInt = -1;
    public Text ScoreText;

    private void OnTriggerEnter(Collider other)
    {
        ScoreInt++;
        if(other.tag == "Obstacle")
        {
            deadplayer++;
            if (deadplayer > maxVite)
            {
                LevelGenerator.speed = 0;
                animator.SetBool("deadAnimation", true);
                Invoke ("GameOver", 3);
            }
        }
    }

    public void Start()
    {
        
        animator = GetComponent<Animator>();
        animator.SetBool("deadAnimation", false);
        animator.SetBool("Idle", false);
        Time.timeScale = 1;
        if (MainMenu.animationStart)
        {
            animator.SetBool("deadAnimation", false);
            animator.SetBool("Idle", false);
            LevelGenerator.speed = LevelGenerator.maxSpeed;
        }
    }
    void Update() 
    {
        if (Gameover.activeSelf)
        {
            gameOverBool = true;
        }
        idle = animator.GetBool("deadAnimation");
        if (LevelGenerator.speed == 0 && idle == false)
        {
            animator.SetBool("Idle", true);
        }
        if (MainMenu.animationStart)
        {
            animator.SetBool("Idle", false);
            animator.SetBool("deadAnimation", false);
            LevelGenerator.speed = LevelGenerator.maxSpeed;
            Time.timeScale = 1;
        }
        ScoreText.text = ScoreInt.ToString();
    }
    void GameOver()
    {
        Gameover.SetActive(true);
        Game.SetActive(false);
    }
}
