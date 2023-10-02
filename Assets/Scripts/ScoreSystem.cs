using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private float _scoreMultiplier;

    public const string HIGHSCOREKEY= "HighScore";
    private float _score;

    void Update()
    {
        _score += Time.deltaTime * _scoreMultiplier;
        _scoreText.text = Mathf.FloorToInt(_score).ToString();
    }

    private void OnDestroy()
    {
        int currentHighscore = PlayerPrefs.GetInt(HIGHSCOREKEY, 0);
        
        if (_score > currentHighscore)
        {
            PlayerPrefs.SetInt(HIGHSCOREKEY, Mathf.FloorToInt(_score));
        }
    }
}
