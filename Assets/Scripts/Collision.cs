using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision :
 MonoBehaviour
{
    int deadplayer = 1;
    private Animator animator;
    public GameObject Player;
    bool idle = false;
    public int maxVite = 2;
    public GameObject Gameover;
    public GameObject Game;
    private void OnTriggerEnter(Collider other)
    {
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
        if (MainMenu.animationStart)
        {
            animator.SetBool("deadAnimation", false);
            animator.SetBool("Idle", false);
        }
    }
    void Update() 
    {
        idle = animator.GetBool("deadAnimation");
        if (LevelGenerator.speed == 0 && idle == false)
        {
            animator.SetBool("Idle", true);
        }
    }
    void GameOver()
    {
        Gameover.SetActive(true);
        Game.SetActive(false);
    }
}
