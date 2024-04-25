using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField] TextMeshProUGUI addButtonText;

    int _score = 0;
    int _scoreMultiplier = 1;

    private void Awake()
    {
        _score = PlayerPrefs.GetInt("Score", 0);
        UpdateScore();

        _scoreMultiplier = PlayerPrefs.GetInt("ScoreMultiplier", 1);
        UpdateScoreMultiplier();        
    }

    public void PlusButton()
    {
        _score += _scoreMultiplier;
        UpdateScore();
    }

    public void UpgradeButton()
    {
        if (_score >= 10)
        {
            ???     
        }
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }

    void UpdateScore()
    {
        PlayerPrefs.SetInt("Score", _score);
        _scoreText.text = _score.ToString();
    }

    void UpdateScoreMultiplier()
    {
        ???       
    }
}
