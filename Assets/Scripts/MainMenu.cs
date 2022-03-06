using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text highScoreText;

    public void Play()
    {
        SceneManager.LoadScene("SceneGame");
    }

    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt(ScoreSystem.HighScoreKey, 0).ToString();
    }


}
