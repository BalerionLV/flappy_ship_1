using UnityEngine;

public class ObstacleSpawnLogic : MonoBehaviour
{
    public GameObject obstacle;
    public float SpawnInterval = 2;
    public float timer = 0f;

    private float maxObstacleHeight = 2.8f;
    private float minObstacleHeight = -2.8f;

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
        Vector3 randomPosition = new Vector3(transform.position.x, Random.Range(minObstacleHeight, maxObstacleHeight), transform.position.z);
        Instantiate(obstacle, randomPosition, Quaternion.identity);
    }
}
