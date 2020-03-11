using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //Variables
    private int score = 0;
    private int highScore;
    public Text scoreText;
    public Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString("D4");
        highScoreText.text = highScore.ToString("D4");

        if (score > highScore)
        {
            highScore = score;
        }
    }

    //Getter and setter
    public int getScore()
    {
        return score;
    }

    public void setScore(int s)
    {
        score = s;
    }

    public int getHighScore()
    {
        return highScore;
    }

    public void setHighScore(int s)
    {
        highScore = s;
    }
}
