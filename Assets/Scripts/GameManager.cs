using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text _scoreText, _startText, _youWonText, _restartButton, _nextLevelButton, _mainMenuButton, _resumeButton;

    int _currentScreenIndex;

    public int Score = 0;

    void Start()
    {
        _currentScreenIndex = SceneManager.GetActiveScene().buildIndex;
        DeactivatingUI();
        _scoreText.text = "Score: " + 0.ToString();
        StartCoroutine(StartText());
    }

    void Update()
    {
        _scoreText.text = "Score: " + Score;
        LevelManager();
    }

    void LevelManager()
    {
        if(_currentScreenIndex == 1)
        {
            if(Score == 20)
            {
                ActivatingUI();
            }
        }

        if (_currentScreenIndex == 2)
        {
            if (Score == 25)
            {
                ActivatingUI();
            }
        }

        if (_currentScreenIndex == 3)
        {
            if (Score == 30)
            {
                ActivatingUI();
            }
        }

        if (_currentScreenIndex == 4)
        {
            if (Score == 35)
            {
                ActivatingUI();
            }
        }

        if (_currentScreenIndex == 5)
        {
            if (Score == 40)
            {
                ActivatingUI();
            }
        }
    }

    void ActivatingUI()
    {
        Time.timeScale = 0;

        _mainMenuButton.gameObject.SetActive(true);
        _restartButton.gameObject.SetActive(true);
        _nextLevelButton.gameObject.SetActive(true);
        _youWonText.gameObject.SetActive(true);
    }

    void DeactivatingUI()
    {
        _mainMenuButton.gameObject.SetActive(false);
        _restartButton.gameObject.SetActive(false);
        _nextLevelButton.gameObject.SetActive(false);
        _youWonText.gameObject.SetActive(false);
    }

    IEnumerator StartText()
    {
        _startText.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        _startText.gameObject.SetActive(false);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(_currentScreenIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(_currentScreenIndex + 1);
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        _restartButton.gameObject.SetActive(true);
        _resumeButton.gameObject.SetActive(true);
        _mainMenuButton.gameObject.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        _restartButton.gameObject.SetActive(false);
        _resumeButton.gameObject.SetActive(false);
        _mainMenuButton.gameObject.SetActive(false);
    }
}
