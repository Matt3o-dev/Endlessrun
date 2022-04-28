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
    public int maxVite = 2;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            deadplayer++;
            if (deadplayer > maxVite)
            {
                LevelGenerator.speed = 0;
                animator.SetBool("deadAnimation", true);
            }
            
        }
    }
    public void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("deadAnimation", false);
    }
}
