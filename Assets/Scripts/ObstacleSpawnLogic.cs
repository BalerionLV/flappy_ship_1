using UnityEngine;

public class ObstacleSpawnLogic : MonoBehaviour
{
    public GameObject obstacle;
    public float SpawnInterval = 2;
    public float timer = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > SpawnInterval)
        {
            SpawnObstacle();
            timer = 0f;
        }
        timer += Time.deltaTime;
    }

    void SpawnObstacle()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }
}
