/* 
 * (Logan Ross) 
 * (Assignment 2) 
 * (Tracks the players score as well as if the player wins or loses) 
 * also allows game to be restarted
 */

using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UpdateScoreX: MonoBehaviour
{
    public Text txtScoreText;
    public Text txtGameOver;
    public static int currentScore;
    public static bool gameOver;
    public static bool won;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        gameOver = false;
        txtGameOver.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        txtScoreText.text = "Score: " + currentScore;

        if(currentScore == 5)
        {
            gameOver = true;
            won = true;
        }
        
        if(gameOver)
        {
            if(won)
            {
                txtGameOver.text = "You Win! \nPress R to restart";
            }
            else
            {
                txtGameOver.text = "You Lose! \nPress R to restart";
            }
        }

        if(Input.GetKeyDown(KeyCode.R) && gameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
