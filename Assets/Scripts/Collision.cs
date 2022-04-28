using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    int deadplayer = 1;
    public GameObject Player;
    public int maxVite = 2;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            deadplayer++;
            if (deadplayer > maxVite)
            {
                Destroy(Player);
            }
            
        }
    }
}
