using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AddObstacles : MonoBehaviour
{

    public GameObject[] obstacles;

    private Queue<GameObject> currentObstacles = new Queue<GameObject>();
    private float _height = 20;
    void Start()
    {
        // for (int i = 0; i < 5; i++)
        // {
        //     Debug.Log(GetRandomObstacle());
        // }
        AddObstacle();
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
        
        return obstacle;
    }

    private GameObject GetRandomObstacle()
    {
        return obstacles[Random.Range(0, obstacles.Length)];
    }
}
