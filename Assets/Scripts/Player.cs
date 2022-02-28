using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] float _speed = 100;
    [SerializeField] Text _gameoverText, _restartButton, _mainMenuButton;
    

    Vector3 _Direction = Vector3.right;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        _gameoverText.gameObject.SetActive(false);
        _restartButton.gameObject.SetActive(false);
        _mainMenuButton.gameObject.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        MobileMovement();

        PcMovement();
    }

    public void SpeedUp()
    {
        _speed++;
    }

    void PcMovement()
    {
        transform.Translate(_Direction * Time.deltaTime * _speed);

        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            _Direction = Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _Direction = Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            _Direction = Vector3.down;
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            _Direction = Vector3.right;
        }
    }

    void MobileMovement()
    {
        // For Player Movement.
        transform.Translate(_Direction * Time.deltaTime * _speed);
    }

    // If Player Wants to go Up.
    public void MoveUp()
    {
        _Direction = Vector3.up;
    }

    // If Player Wants to go Down.
    public void MoveDown()
    {
        _Direction = Vector3.down;
    }

    // If Player Wants to go Right.
    public void MoveRight()
    {
        _Direction = Vector3.right;
    }

    // If Player Wants to go Left.
    public void MoveLeft()
    {
        _Direction = Vector3.left;
    }

    // When Player Collide with Border
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Wall")
        {
            Time.timeScale = 0;
            _gameoverText.gameObject.SetActive(true);
            _restartButton.gameObject.SetActive(true);
            _mainMenuButton.gameObject.SetActive(true);
        }
    }
}
