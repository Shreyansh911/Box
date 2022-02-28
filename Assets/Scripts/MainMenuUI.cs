using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] Text _startButton, _exitButton, _titleText, _level1, _level2, _level3, _level4, _level5, _endless;

    // Start is called before the first frame update
    void Start()
    {
        ActivatingLevels();
    }

    public void StartGame()
    {
        _startButton.gameObject.SetActive(false);
        _exitButton.gameObject.SetActive(false);
        _titleText.gameObject.SetActive(false);

        DeactivatingLevels();

    }

    private void DeactivatingLevels()
    {
        _level1.gameObject.SetActive(true);
        _level2.gameObject.SetActive(true);
        _level3.gameObject.SetActive(true);
        _level4.gameObject.SetActive(true);
        _level5.gameObject.SetActive(true);
        _endless.gameObject.SetActive(true);
    }

    private void ActivatingLevels()
    {
        _level1.gameObject.SetActive(false);
        _level2.gameObject.SetActive(false);
        _level3.gameObject.SetActive(false);
        _level4.gameObject.SetActive(false);
        _level5.gameObject.SetActive(false);
        _endless.gameObject.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadLevel5()
    {
        SceneManager.LoadScene(5);
    }

    public void Endless()
    {
        SceneManager.LoadScene(6);
    }
}
