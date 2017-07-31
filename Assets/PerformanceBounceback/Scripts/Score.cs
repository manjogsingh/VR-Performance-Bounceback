using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameManager gameManager;
    Text text;
    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        text = GetComponentInChildren<Text>();
    }

    private int oldScore;
    void Update()
    {
        if (gameManager.score != oldScore)
        {
            oldScore = gameManager.score;
            ChangeScoreUI();
        }
    }
    private void ChangeScoreUI()
    {
        text.text = "Score: " + gameManager.score.ToString();
    }
}