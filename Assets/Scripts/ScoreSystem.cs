using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float ScoreMultiplier=5;
    public const string HighScoreKey = "HighScore";
    public const string CurrentScoreKey = "CurrentScore";


    private float score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * ScoreMultiplier;

        scoreText.text = Mathf.FloorToInt(score).ToString();
        


    }

    private void OnDestroy()
    {

        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey, 0);
        PlayerPrefs.SetInt(CurrentScoreKey, Mathf.FloorToInt(score));

        if (score> currentHighScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, Mathf.FloorToInt(score));
        }
        
    }

}
