using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text highScoreText;

    private void Start()
    {
       int score = PlayerPrefs.GetInt(ScoreSystem.HIGHSCOREKEY, 0);

       highScoreText.text = $"High Score: {score}";
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    } 

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
