using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private Score ScoreText;

    private void Start()
    {
        ScoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Score>();
    }

    private void Update()
    {
        gameObject.transform.Rotate(0.5f, 1, 0.3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        ScoreText.ScorePlusOne();
        Destroy(gameObject);
        Health.health = Health.health +10;
    }
}
