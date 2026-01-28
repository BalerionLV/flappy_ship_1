using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    private GameLogicScript _gameLogic;
    public float speed = 5f;
    private float gameObjectCleanupPos = -15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameLogic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x < gameObjectCleanupPos)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerShip"))
        {
            _gameLogic.GameOver();
        }
    }
}
