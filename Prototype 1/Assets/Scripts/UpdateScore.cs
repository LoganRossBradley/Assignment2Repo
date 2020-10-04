/*
 * Logan ross
 * assignment 2
 * deals with game overs and restarts
 */

using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;

    public Text txtScore;
    public Text txtGameOver;

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver)
        {
            txtScore.text = "Score: " + score;
        }
        if(score >= 3)
        {
            won = true;
            gameOver = true;
        }
        if(gameOver)
        {
            if (won)
            {
                txtGameOver.text = "You win! \nPress 'R' to play again.";
            }else
            {
                txtGameOver.text = "You lose! \nPress 'R' to try again.";
            }

            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
