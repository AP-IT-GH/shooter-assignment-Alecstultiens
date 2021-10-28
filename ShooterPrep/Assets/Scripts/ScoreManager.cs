using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    int score = 0;
    private int maxScore = 4;
    public GameWonScript GameWonScript;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

        scoreText.text = "SCORE: " + score.ToString() + "/" +maxScore.ToString();
        
    }

    public void AddPoint()
    {
        score += 1;
        if(score >= maxScore)
        {
            scoreText.text = "";
            GameWonScript.Setup(score);
        }
        scoreText.text = "SCORE: " + score.ToString() + "/" + maxScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
