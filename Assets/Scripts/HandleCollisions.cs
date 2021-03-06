﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleCollisions : MonoBehaviour
{
    private bool _gameHasEnded = false;
    
    void Update()
    {
        if (transform.position.y < -1f)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        if (!_gameHasEnded)
        {
            _gameHasEnded = true;
            Debug.Log("GameOver");
            Invoke("Restart", 0.5f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            EndGame();
        }
    }
}
