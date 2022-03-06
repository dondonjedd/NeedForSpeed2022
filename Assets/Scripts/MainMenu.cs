using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text highScoreText;
    [SerializeField] private TMP_Text currentScoreText;
   

    public void Play()
    {
        SceneManager.LoadScene("SceneGame");
    }



    void Start()
    {
        highScoreText.text = "High Score: "+PlayerPrefs.GetInt(ScoreSystem.HighScoreKey, 0).ToString();

        if (PlayerPrefs.GetInt(ScoreSystem.CurrentScoreKey, 0) == 0)
        {
            currentScoreText.text = "";
        }
        else
        {
            currentScoreText.text = "Your Score: "+ PlayerPrefs.GetInt(ScoreSystem.CurrentScoreKey, 0).ToString();
            PlayerPrefs.SetInt(ScoreSystem.CurrentScoreKey, 0);

        }
    }







}
