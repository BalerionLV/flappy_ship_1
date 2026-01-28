using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    public Rigidbody2D body;
    public float jumpPower = 10f;

    private bool gameOver = false;
    public GameLogicScript _gameLogic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameLogic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if((transform.position.y > 5.8 || transform.position.y < -7.2) && !gameOver)
        {
            GameOver();
        }
    }

    void OnJump(InputValue value)
    {
        if (value.isPressed && !gameOver)
        {
            body.linearVelocity = new Vector2(0f, jumpPower);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!gameOver)
        {
            GameOver();
        }
    }

    void GameOver() {
        gameOver = true;
        _gameLogic.GameOver();
    }
}
