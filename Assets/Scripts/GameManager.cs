using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameOver;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        gameOver = false;
    }

    void Update()
    {
        
    }

    public void StartGame()
    {
        UiManager.instance.GameStart();
        ScoreManager.instance.startScore();
        GameObject.Find("PlatformSpawner").GetComponent<PlatformSpawner>().startSpawning();
    }

    public void GameOver()
    {
        UiManager.instance.GameOver();
        ScoreManager.instance.stopScore();
        gameOver = true;
    }
}
