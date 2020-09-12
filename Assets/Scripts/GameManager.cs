using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;

    public EnemyManager enemyManager;
    public Player player;

    int playerHealth;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        enemyManager = GetComponent<EnemyManager>();
        
    }

    void Update()
    {
        playerHealth = player.currentHealth;
        if (playerHealth == 0)
            GameOver();
    }

    void GameOver()
    {
        Debug.Log("Game over");
    }

    
}
