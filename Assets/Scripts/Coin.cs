using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private Collider ScoreText;

    private void Start()
    {
        
    }

    private void Update()
    {
        gameObject.transform.Rotate(0.5f, 1, 0.3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Health.health = Health.health +10;
    }
}
