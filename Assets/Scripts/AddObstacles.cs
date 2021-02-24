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

    // Update is called once per frame
    void Update()
    {
        
    }

    private GameObject AddObstacle()
    {
        GameObject newObstacle = GetRandomObstacle();
        Vector3 newObstaclePos = newObstacle.transform.position;

        GameObject obstacle = Instantiate(newObstacle, new Vector3(newObstaclePos.x, newObstaclePos.y, _height), Quaternion.identity);

        if (_previousObstacle)
        {
            Debug.Log(obstacle.GetInstanceID());
            Debug.Log(_previousObstacle.GetInstanceID());
        }    
        
        
        _height += 10;
        _previousObstacle = obstacle;
        return obstacle;
    }

    private GameObject GetRandomObstacle()
    {
        return obstacles[Random.Range(0, obstacles.Length)];
    }
}
