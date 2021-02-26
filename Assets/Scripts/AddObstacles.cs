using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AddObstacles : MonoBehaviour
{

    public GameObject[] obstacles;

    private Queue<GameObject> currentObstacles = new Queue<GameObject>();
    private float _height = 20;
    private GameObject _previousObstacle;
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            AddObstacle();
        }
    }

    private GameObject AddObstacle()
    {
        GameObject newObstacle = GetRandomObstacle();
        Vector3 newObstaclePos = newObstacle.transform.position;

        GameObject obstacle = Instantiate(newObstacle, new Vector3(newObstaclePos.x, newObstaclePos.y, _height), Quaternion.identity);


        _height += 10;
        _previousObstacle = obstacle;
        return obstacle;
    }

    private GameObject GetRandomObstacle()
    {
        GameObject obstacle = obstacles[Random.Range(0, obstacles.Length)];

        if (_previousObstacle)
        {
            if (_previousObstacle.tag == obstacle.tag)
            {
                return GetRandomObstacle();
            }
        }

        _previousObstacle = obstacle;
        return obstacle;
    }
}
